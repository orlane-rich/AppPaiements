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
        public void AfficherDetails() 
        {
            Console.WriteLine ($"Montant: {Montant}, Description: {Description}, NumeroCarte:{NumeroCarte}");
        }

    
}
