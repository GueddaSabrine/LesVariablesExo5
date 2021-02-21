using System;

namespace LesVariablesExo5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Via la console, demander à l’utilisateur de renseigner son nom et son prénom. 
            Une fois tous les éléments renseignés, faire en sorte d’afficher dans la console la phrase suivante :
            « Bonjour Nom Prénom, nous sommes le jour date mois, comment allez - vous ? »*/

            Console.WriteLine("Entrez votre nom : ");
            string snom = Console.ReadLine();
            Console.WriteLine("Entrez votre prénom : ");
            string sprenom = Console.ReadLine();

            DateTime date = DateTime.Today;

            Console.WriteLine($"Bonjour {snom} {sprenom}, nous sommes le {date}, comment allez-vous ? ");
        }
    }
}
