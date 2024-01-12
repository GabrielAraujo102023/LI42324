using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinToWin
{
    internal class Client
    {
        public string Email { get; set; }
        public string Pass { get; set; }
        public double Dinheiro { get; set; }

        // Default Constructor
        public Client()
        {
        }

        // Parameterized Constructor
        public Client(string email, string pass, double dinheiro)
        {
            Email = email;
            Pass = pass;
            Dinheiro = dinheiro;
        }

        // Copy Constructor (Cloning)
        public Client(Client other)
        {
            Email = other.Email;
            Pass = other.Pass;
            Dinheiro = other.Dinheiro;
        }

        // Clone method
        public Client Clone()
        {
            return new Client(this);
        }

        // ToString method
        public override string ToString()
        {
            return $"Email: {Email}, Pass: {Pass}, Dinheiro: {Dinheiro:C}";
        }
    }
}
