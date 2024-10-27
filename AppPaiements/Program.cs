using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {

        CarteCredit CarteCredit1 = new CarteCredit(2500, "sac Hermes", 5058);
        CarteCredit CarteCredit2 = new CarteCredit(1600, "Vetements", 4724);
        CarteCredit CarteCredit3 = new CarteCredit(250, "Groceries", 5052);
    }
}