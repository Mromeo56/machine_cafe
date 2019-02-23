using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_slam2_romeo_moreaux_partie2
{
    class Program
    {
        static int choix = 0;

        static bool OuiOuNon(string reponse)
        {
            bool oui = true;

            if(reponse == "oui")
            {
                oui = true;

            }
            else
            {
                oui = false;
            }

            return (oui);
        }

        static void Main(string[] args)
        {
            bool encoreBoisson = true;
            boisson cafeCourt = new boisson("cafe court", "café court expresso", 0.5F, 10, 1, true, "chaude");
            boisson cafeLong = new boisson("cafe long", "café long", 0.5F, 10, 1, true, "chaude");
            boisson capuccino = new boisson("capuccino", "café avec une mousse de lait onctueuse", 0.5F, 10, 2, true, "chaude");
            boisson theNature = new boisson("the nature", "the noir ceylan", 0.7F, 10, 1, true, "chaude");
            boisson theMenthe = new boisson("the menthe", "the vert aromatise a la menthe", 0.75F, 10, 2, true, "chaude");
            boisson potageTomate = new boisson("potage", "potage chaud a base de concentré de tomates", 0.4F, 10, 0, false, "chaude");
            boisson orange = new boisson("orange", "boisson a base de concentré d'oranges", 0.55F, 10, 0, false, "froide");
            boisson b = new boisson("", "", 0.0F, 0, 0, false, "");

            do
            {               

                string reponse;
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Choississez votre boisson.");
                Console.WriteLine("- 1 pour : Cafe court");
                Console.WriteLine("- 2 pour : Cafe long");
                Console.WriteLine("- 3 pour : Capuccino");
                Console.WriteLine("- 4 pour : The nature");
                Console.WriteLine("- 5 pour : The menthe");
                Console.WriteLine("- 6 pour : Potage Tomate");
                Console.WriteLine("- 7 pour : Orange");
                Console.WriteLine("- 8 pour quitter.");
                Console.WriteLine("-----------------------------");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1: b = cafeCourt; break;
                    case 2: b = cafeLong; break;
                    case 3: b = capuccino; break;
                    case 4: b = theNature; break;
                    case 5: b = theMenthe; break;
                    case 6: b = potageTomate; break;
                    case 7: b = orange; break;
                    case 8: break;
                }


                Console.Clear();
                Console.WriteLine("-----------------------------");
                b.getDescription();
                Console.WriteLine("Votre boisson est une boisson "+ b.getChaudFroid() + ".");
                Console.WriteLine("La quantité de sucre est de niveau " + b.getSucre());
                Console.WriteLine("PREPARATION EN COURS, VOUS DEVEZ PAYEZ " + b.getPrix() +". (Appuyez sur Entrée pour payer)");
                Console.WriteLine("-----------------------------");
                Console.ReadKey();

                Console.Clear();                

                if (b.diminutionStock() == true)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Voulez-vous une autre boisson ?");
                    Console.WriteLine("-----------------------------");
                    reponse = Console.ReadLine();

                    if(OuiOuNon(reponse) == true)
                    {
                        encoreBoisson = true; 
                    }
                    else
                    {
                        encoreBoisson = false;                      
                    }
                }

                else
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Stock épuisé.");
                    Console.WriteLine("-----------------------------");
                    encoreBoisson = false;
                }
                Console.ReadKey();

            } while (encoreBoisson == true && b.getStock() > 0);

            Console.ReadKey();
        }
    }
}
