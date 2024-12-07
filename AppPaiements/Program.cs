using AppPaiements;
using System.Runtime.ConstrainedExecution;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
    // Instances de la classe CarteCredit
        CarteCredit CarteCredit1 = new CarteCredit(2500, "sac Hermes", 5058);
        CarteCredit CarteCredit2 = new CarteCredit(1600, "Vetements", 4724);
        CarteCredit CarteCredit3 = new CarteCredit(250, "Groceries", 5052);

        CarteCredit1.AfficherDetails();
        CarteCredit2.AfficherDetails();
        CarteCredit3.AfficherDetails();

        // Instances de la classe Paypal
        Paypal Paypal1 = new Paypal(700, "Loisir", "orlanesegolene@icloud.com");
        Paypal Paypal2 = new Paypal(250, "Transport", "orlaneketcha64@gmail.com");

        Paypal1.AfficherDetails();
        Paypal2.AfficherDetails();


        Utilisateur utilisateur = new Utilisateur("Orlane Ketcha");

        utilisateur.AjouterPaiement(CarteCredit1);
        utilisateur.AjouterPaiement(CarteCredit2);
        utilisateur.AjouterPaiement(CarteCredit3);
        utilisateur.AjouterPaiement(Paypal1);
        utilisateur.AjouterPaiement(Paypal2);


        utilisateur.AfficherInfos();
    }
}