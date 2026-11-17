using System.Security.Cryptography.X509Certificates;

namespace szamonkereslinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Szornyelemzo elemzo = new Szornyelemzo();

            Console.WriteLine("Szörnyek:");
            foreach (string nev in elemzo.OsszesSzornyNevListaba())
            {
                Console.WriteLine(nev);
            }

            Console.WriteLine("Átlagos veszélyesség: " + elemzo.AtlagosVeszelyesseg());
            Console.WriteLine("Van nagyon veszélyes, tűztől gyenge szörny: " + elemzo.vanExtremTuzGyengeSzorny());
        }
    }
}
