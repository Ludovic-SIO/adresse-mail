using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {    static string adresse (string domaine,string nom, string prenom)
        {
            string a = ".";
            string b = "@";

            return nom+ a + prenom + b+domaine;
        }
        static void Main(string[] args)
        {
            string domaine;
            string nom;
            string prenom;

            Console.WriteLine("Ecris ton nom");
            nom = Console.ReadLine();
            Console.WriteLine("ton nom est {0}",nom);
            Console.WriteLine("Ecris ton prenom");
            prenom = Console.ReadLine();
            Console.WriteLine("ton prenom est {0}", prenom);
            Console.WriteLine("Ecris ton domaine");
            domaine = Console.ReadLine();
            Console.WriteLine("ton adresse est {0}", domaine);

            Console.WriteLine("Ton adresse complète est {0}",adresse (domaine,nom,prenom));
        }
    }
}
