using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paiement
    {
        public int Montant { get; set; }
        public string Description { get; set; }
        public Paiement(int montant, string description)
        {
            Montant = montant;
            Description = description;
        }
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Montant : {Montant}, Description: {Description}");
        }
    }
}
