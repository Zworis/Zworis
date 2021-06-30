using System;

namespace Phone_Project
{
    public class Phone
    {
        public string ceo;
        public string merk;
        public string versie;
        public string os;
        public float prijs;
        public float verzend;
        public Phone(string nCeo, string nMerk, string nVersie, string nOs, float nPrijs, float nVerzend)
        {
            ceo = nCeo;
            merk = nMerk;
            versie = nVersie;
            os = nOs;
            prijs = nPrijs;
            verzend = nVerzend;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Alle Phones aanduiden
            Phone Phone1 = new Phone("Steve Jobs", "Apple", "Iphone XS", "IOS", 845, 16);
            Phone Phone2 = new Phone("Lee Byung-chull", "Samsung", "Galaxy S7", "Android", 370, 23);
            Phone Phone3 = new Phone("Sundar Pichai", "Google", "Pixel 3", "Chrome Os", 240, 20);
            Phone Keuze1 = new Phone("", "", "", "", 0, 0);

            //De CEO's van de merken aanduiden
            Console.WriteLine(Phone1.ceo);
            Console.WriteLine(Phone2.ceo);
            Console.WriteLine(Phone3.ceo);

            //vragen welke mobieltjes de gebruiker wilt kopen
            Console.WriteLine("Welke mobieltjes wilt u kopen?: " + Phone1.versie +"("+ Phone1.prijs + ")" + ", " + Phone2.versie + "(" + Phone2.prijs + ")" + ", " + Phone3.versie + "(" + Phone3.prijs + ")");
            Console.WriteLine(Phone1.versie + " is [1]. " + Phone2.versie + " is [2]. " + Phone3.versie + " is [3]. ");
            string keuze = Console.ReadLine();
            if (keuze == "1")
            {
                Keuze1 = (Phone) Phone1.Clone();
            }
            else if (keuze == "2")
            {
                Keuze1 = (Phone)Phone2.Clone();
            }
            else if (keuze == "3")
            {
                Keuze1 = (Phone)Phone3.Clone();
            }

            Console.WriteLine("Hoeveel wilt u?");
            int aantal = Convert.ToInt32(Console.ReadLine());
            float lol = Keuze1.prijs;
            double prijs = (lol * aantal) * 1.21f + Keuze1.verzend;

            if (prijs > 3000)
            {
                prijs = prijs * 0.90f;
            }
            prijs = Math.Round(prijs, 2);
            Console.WriteLine(prijs);
            

        }
    }
}
