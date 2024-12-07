using AppPaiements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


       
    internal class CarteCredit : Paiement 
    { //Proprietes
        public int NumeroCarte {  get; set; }
    // Constructeur
    public CarteCredit (int montant, string description, int numeroCarte) : base (montant, description)
        {
            NumeroCarte = numeroCarte;
        }
        public override void AfficherDetails() 
        {
            Console.WriteLine ($"Infos Carte de credit - Montant: {Montant}, Description: {Description}, NumeroCarte:{NumeroCarte}");
        }

    
}
