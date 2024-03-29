﻿using System.Timers;
using Timer = System.Timers.Timer;

namespace SpinToWin
{
    internal class TimeManager
    {
        private static Timer timer;
        private static LeilaoDAO leilaoDAO;
        private static VinilDAO vinilDAO;
        private int passar = 0;

        public TimeManager() { }
        public TimeManager(int passar)
        {
            this.passar = passar;
        }
        public void Run()
        {
            new Thread(() =>
            {
                // Stop and dispose of the existing timer, if any
                if (timer != null)
                {
                    timer.Stop();
                    timer.Dispose();
                }

                // Create a timer with a 10-minute interval
                timer = new Timer();
                timer.Interval = 10 * 60 * 1000; // 10 minutes in milliseconds

                // Hook up the Elapsed event
                timer.Elapsed += OnTimedEvent;
                Console.WriteLine("Timer Inicializado.");

                // Start the timer
                timer.Start();

            }).Start();
        }

        public void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Timed Event Started");
            leilaoDAO = new LeilaoDAO();
            vinilDAO = new VinilDAO();
            List<Leilao> leiloes = leilaoDAO.GetListLeiloes();
            leiloes.RemoveAll(l => l.Estado == "fechado");
            DateTime now = DateTime.Now;
            if (passar > 0)
            {
                now = now.AddHours(passar);
                Console.WriteLine("AVANCEI {0} HORAS", passar);
            }
            foreach (Leilao l in leiloes)
            {
                float decr = l.ValorBase * 0.02f;
                int hoursElapsed = calculateHoursElapsed(l.ValorBase, l.PrecoVenda, decr);
                if (l.Estado == "aberto")
                {
                    if ((now - l.TempoCriacao.AddHours(hoursElapsed + 11)) >= TimeSpan.FromHours(1))
                    {
                        l.PrecoVenda -= decr;
                        if (l.PrecoVenda <= l.ValorMinimo)
                        {
                            l.PrecoVenda = l.ValorMinimo;
                            l.Estado = "lastChance";
                        }
                        leilaoDAO.UpdateLeilao((int)l.IdLeilao, l);
                        Console.WriteLine("Diminuido preço de leilao {0}", l.IdLeilao);
                    }
                }
                else if (l.Estado == "lastChance")
                {
                    if ((now - l.TempoCriacao.AddHours(hoursElapsed + 11)) >= TimeSpan.FromHours(12))
                    {
                        l.Estado = "fechado";

                        //==============================EMAIL NOTIFICATION VENDOR===========================
                        
                        ClientDAO clientDAO = new ClientDAO();
                        Client vendedor = clientDAO.GetClientbyID(l.Vendedor);
                        PassRecovery mail = new PassRecovery("null", vendedor.Email);

                        string corpo = $"Prezado Usuário,\n\n"
                                    + "O seu Leilão foi Fechado visto que não foi possivel Realizar a Venda\n\n"
                                    + "Obrigado,\nA Equipa Spin2Win";


                        Google.Apis.Gmail.v1.Data.Message message = mail.CreateMessage("li4spin2win@gmail.com", vendedor.Email, "Leilão Concluido", corpo);


                        mail.SendMessage(mail.GmailService, "li4spin2win@gmail.com", message, 0);

                        //===========================================================================

                        List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);
                        vinis.ForEach(v => 
                        { 
                            v.Leilao = null; 
                            vinilDAO.UpdateVinil((int)v.IdVinil, v); 
                        });
                        leilaoDAO.UpdateLeilao((int)l.IdLeilao, l);
                        Console.WriteLine("Leilao {0} fechado", l.IdLeilao);
                    }
                }
                else
                {
                    if ((now - l.TempoCriacao) >= TimeSpan.FromHours(12))
                    {
                        l.Estado = "aberto";
                        List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);
                        leilaoDAO.UpdateLeilao((int)l.IdLeilao, l);
                        Console.WriteLine("Leilao {0} aberto", l.IdLeilao);
                    }
                }
            }
        }

        public static int calculateHoursElapsed(float vBase, float pVenda, float decr)
        {
            int hours = 0;
            if (vBase == pVenda)
                return 0;
            while (vBase > pVenda)
            {
                vBase -= decr;
                hours++;
            }
            return hours;
        }
    }
}
