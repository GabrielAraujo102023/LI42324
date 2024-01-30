using System.Timers;
using Timer = System.Timers.Timer;

namespace SpinToWin
{
    internal class TimeManager
    {
        private static Timer timer;
        private static LeilaoDAO leilaoDAO;
        private static VinilDAO vinilDAO;
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

        private static void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Timed Event Started");
            leilaoDAO = new LeilaoDAO();
            vinilDAO = new VinilDAO();
            List<Leilao> leiloes = leilaoDAO.GetListLeiloes();
            leiloes.RemoveAll(l => l.Estado != "aberto" && l.Estado != "lastChance");
            DateTime now = DateTime.Now;
            foreach(Leilao l in leiloes)
            {
                float decr = l.ValorBase * 0.02f;
                int hoursElapsed = calculateHoursElapsed(l.ValorBase, l.PrecoVenda, decr);
                if(l.Estado == "aberto")
                {
                    if((now - l.TempoCriacao.AddHours(hoursElapsed)) >= TimeSpan.FromHours(1))
                    {
                        l.PrecoVenda -= decr;
                        if (l.PrecoVenda < l.ValorMinimo)
                        {
                            l.PrecoVenda = l.ValorMinimo;
                            l.Estado = "lastChance";
                        }
                        leilaoDAO.UpdateLeilao((int)l.IdLeilao, l);
                        Console.WriteLine("Diminuido preço de leilao {0}", l.IdLeilao);
                    }
                }
                else
                {
                    if((now - l.TempoCriacao.AddHours(hoursElapsed)) >= TimeSpan.FromHours(12))
                    {
                        l.Estado = "fechado";
                        List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);
                        vinis.ForEach(v => { v.Leilao = null; vinilDAO.UpdateVinil((int)v.IdVinil, v); });
                        leilaoDAO.UpdateLeilao((int)l.IdLeilao, l);
                        Console.WriteLine("Leilao {0} fechado", l.IdLeilao);
                    }
                }
            }
        }

        private static int calculateHoursElapsed(float vBase, float pVenda, float decr)
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
