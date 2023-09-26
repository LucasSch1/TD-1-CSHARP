using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer un montant à décomposer :");
            //Initialisation des variables
            string montant = Console.ReadLine();
            int montantentier = Convert.ToInt32(montant);

            int billet100 = 0;
            int billet50 = 0;
            int billet10 = 0;
            int billet5 = 0;
            int piece1 = 0;

            billet100 = montantentier / 100; //Divise la valeur actuelle de montantentier par 100
            montantentier %= 100; //Met a jour la valeur de la variable montantentier par le reste de la division entière

            billet50 = montantentier / 50;
            montantentier %= 50;

            billet10 = montantentier / 10;
            montantentier %= 10;

            billet5 = montantentier / 5;
            montantentier %= 5;

            piece1 = montantentier;






            Console.WriteLine(billet100 +" billet(s) de 100");
            Console.WriteLine(billet50+" billet(s) de 50");
            Console.WriteLine(billet10+" billet(s) de 10");
            Console.WriteLine(billet5+" billet(s) de 5");
            Console.WriteLine(piece1+" pièce(s) de 1");
            Console.Read();

        }
    }
}
