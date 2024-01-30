using Google.Apis.Gmail.v1;
using System.Text;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using MimeKit;

namespace SpinToWin
{
    public partial class PassRecovery : Form
    {
        public PassRecovery()
        {
            InitializeComponent();
            InitializeGmailService();
        }

        private static string? email;
        private static string? validacaocod;
        private static string[] Scopes = { GmailService.Scope.GmailSend };
        private static string ApplicationName = "Spin2Win";//TODO fix path
        private static string CredentialsFileName = "APIkey.json";
        private static string CredentialsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Base de Dados", CredentialsFileName);

        private GmailService gmailService;

        public GmailService GmailService{
            get 
            {
                return gmailService;
            }
        }

        private static readonly string DataStoreFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                                            "Base de Dados",
                                                            "Store");

        private void setEmail(string emailto)
        {
            email = emailto;
        }

        //==========================================INICIALIZAÇÃO SERVIÇO EMAIL====================================

        private void InitializeGmailService()
        {
            try
            {
                UserCredential credential;
                Console.WriteLine(CredentialsFilePath);
                try
                {
                    using (var stream = new FileStream(CredentialsFilePath, FileMode.Open, FileAccess.Read))
                    {
                        ClientSecrets clientSecrets = GoogleClientSecrets.FromStream(stream).Secrets;

                        IDataStore dataStore = new FileDataStore(DataStoreFolder, true);
                        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                            clientSecrets,
                            Scopes,
                            "li4spin2win@gmail.com",
                            CancellationToken.None,
                            dataStore).Result;
                    }

                    var initializer = new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = ApplicationName,
                    };

                    gmailService = new GmailService(initializer);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro Autorização: {ex.Message}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha GmailService: {ex.Message}");
            }
        }
        //============================================================================================================


        //==============================================CODE RANDOM==================================================

        public string RandomizeWords(string input)
        {
            List<string> words = input.Split(' ').ToList();
            Random random = new Random();
            List<string> randomizedWords = words.OrderBy(word => random.Next()).ToList();

            return string.Join(" ", randomizedWords);
        }

        static string GenerateRandomCode(int length)
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            // Generate a random 6-character string
            char[] codeArray = new char[length];
            for (int i = 0; i < length; i++)
            {
                codeArray[i] = characters[random.Next(characters.Length)];
            }

            return new string(codeArray);
        }

        //============================================================================================================


        //============================================TRATAMENTO MENSAGEM=============================================

        private void recover_Click(object sender, EventArgs e)
        {
            //this.Close();

            string recipientEmail = email;
            string code = GenerateRandomCode(6);
            validacaocod = code;

            string subject = "Spin2Win Recover";
            string body = $"Prezado(a) Usuário,\n\n"
                            + "Você solicitou a recuperação da sua senha para a sua conta. "
                            + $"O seu código de verificação é: \t\t {code}\n\n"
                            + "Por favor, utilize este código para redefinir sua senha. Se você não solicitou esta recuperação, "
                            + "pode ignorar este e-mail.\n\n"
                            + "Obrigado,\nA Equipa Spin2Win";


            Google.Apis.Gmail.v1.Data.Message message = CreateMessage("li4spin2win@gmail.com", recipientEmail, subject, body);

            SendMessage(gmailService, "li4spin2win@gmail.com", message,1);
        }

        public Google.Apis.Gmail.v1.Data.Message CreateMessage(string sender, string to, string subject, string body)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("", sender));
            mimeMessage.To.Add(new MailboxAddress("", to));
            mimeMessage.Subject = subject;

            var textPart = new TextPart("plain")
            {
                Text = body,
                ContentTransferEncoding = ContentEncoding.Base64
            };

            textPart.ContentType.Charset = "utf-8";

            mimeMessage.Body = textPart;

            return new Google.Apis.Gmail.v1.Data.Message
            {
                Raw = Base64UrlEncode(mimeMessage.ToString())
            };
        }

        public void SendMessage(GmailService service, string userId, Google.Apis.Gmail.v1.Data.Message gmailMessage,int flag)
        {

            if (service == null)
            {
                MessageBox.Show("GmailService não inicializado");
                return;
            }

            if (gmailMessage == null)
            {
                MessageBox.Show("Mensagem não inicializada");
                return;
            }

            if (flag == 0) {
                service.Users.Messages.Send(gmailMessage, userId).Execute();
            }

            if (flag!=0)
            {
                try
                {

                    service.Users.Messages.Send(gmailMessage, userId).Execute();
                    MessageBox.Show("Por favor confirme na sua caixa de email o código enviado...");
                    cancel.Hide();
                    recover.Hide();
                    msgtexto.Hide();
                    codverification.Show();
                    verify.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro a enviar o email: {ex.Message}");
                }
            }
        }

        private string Base64UrlEncode(string input)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes)
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");
        }

        //============================================================================================================

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void codverification_Click(object sender, EventArgs e)
        {
            this.Text = "";
        }

        private void verify_Click_1(object sender, EventArgs e)
        {
            if (codverification.Text.Equals(validacaocod))
            {
                MessageBox.Show("Código Verificado");
                UserPasswordReset upr  = new UserPasswordReset(email);
                upr.Show();
                this.Close();
            }
                
            else
                MessageBox.Show("Código Errado");
        }
    }
}
