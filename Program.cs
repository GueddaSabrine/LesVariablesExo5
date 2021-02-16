using System;

namespace LesVariablesExo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre nom : ");
            string snom = Console.ReadLine();
            Console.WriteLine("Entrez votre prénom : ");
            string sprenom = Console.ReadLine();

            Console.WriteLine($"Bonjour {snom} {sprenom}, nous sommes le jour date mois, comment allez-vous ? ");
        }
    }
}
