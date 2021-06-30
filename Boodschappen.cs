using System;
namespace Boodschappen_Oefen
{
    class Program
    {
        public static double Boodschap_totaal { get; private set; }
        static void Main(string[] args)
        {
            //de boodschappen aan de klant uitleggen
            Console.WriteLine("We hebben 10 Boodschappen waar je uit kan kiezen.");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("We hebben:");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.75));
            Console.WriteLine("1 Hagelslag ($1,50)");
            Console.WriteLine("2 Kaas ($2,50)");
            Console.WriteLine("3 Patat ($1,00)");
            Console.WriteLine("4 Brood ($2,75)");
            Console.WriteLine("5 Appel ($0.25)");
            Console.WriteLine("6 Jonko ($10,00)");
            Console.WriteLine("7 Avocado ($1,09)");
            Console.WriteLine("8 kant en klare lasagne ($4,00)");
            Console.WriteLine("9 perensap ($1,50)");
            Console.WriteLine("10 kippenpoten ($1,00)");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
            //Lijst van de prijzen van de boodschappen
            double[] Keuzes = { 1.50, 2.50, 1.00, 2.75, 0.25, 10.00, 1.09, 4.00, 1.50, 1.00 };
            //De array maken van wat de gebruiker wilt
            double[] Boodschap_prijs = { 0.0, 0.0, 0.0 };
            double[] Boodschap_hoeveelheid = { 0.0, 0.0, 0.0 };
            string[] intros = { "Wat is je eerste keuze?", "Wat is je tweede keuze?", "Wat is je laatste keuze?" };
            double rente = 21;
            int i = 0;

            void BTW(double Btw_percentage, double hoeveelheid_product, double kosten_product, int u)
            {
                double kosten = hoeveelheid_product * kosten_product;
                double eindkosten = kosten / 100 * Btw_percentage + kosten;
                Boodschap_prijs[u] = eindkosten;

            }



            void kopen()
            {
                
                Console.WriteLine(intros[i]);
                Boodschap_prijs[i] = Keuzes[Convert.ToInt32(Console.ReadLine()) - 1];
                Console.Write("Hoeveel van dit item wil je?");
                Boodschap_hoeveelheid[i] = Convert.ToInt32(Console.ReadLine());
                BTW(rente, Boodschap_hoeveelheid[i], Boodschap_prijs[i], i);
                double Boodschap_totaal = Boodschap_prijs[1] + Boodschap_prijs[2] + Boodschap_prijs[0];
                if (i == 2) 
                {
                    Console.WriteLine(Boodschap_totaal);
                }
            }
            do
            {
                kopen();
                i++;
            } while (i < 3);
        }
    }
}