using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur
    {
        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; }
        public Utilisateur(string nom, List<Paiement> paiements)
        {
            Nom = nom;
            Paiements = paiements;
        }
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Nom : {Nom}, Paiements: {Paiements}");
        }
    }
}
