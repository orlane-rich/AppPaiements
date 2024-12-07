using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal : Paiement
    {
        // Propriétés Paypal
        public string Courriel { get; set; }

        // Constructeur
        public Paypal (int montant, string description, string email) : base(montant, description)
        {
            Courriel = email;
        }


        public override void AfficherDetails()
        {
            Console.WriteLine($"Infos Paypal - Montant: {Montant}, Description: {Description}, Email: {Courriel}");
        }
    }
}
