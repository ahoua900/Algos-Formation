using System;
using System.Collections.Generic;

namespace FormationAlgo
{
    class Program
    {
        #region Calcule  de somme 

        /*static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer votre intervalle de chiffres a calculer séparé par un espace");
            var intervalle = Console.ReadLine();
            var nombres = intervalle.Split(' ');
            var result = Somme(int.Parse(nombres[0]), int.Parse(nombres[1]));
            Console.WriteLine(string.Format("Le resultat est : {0}", result));
        }

        private static object Somme(int v1, int v2)
        {
            var som = 0;
            for (int i = v1; i <= v2; i++)
            {
                som += i;
            }

            return som;
        }*/
        #endregion

        #region Calcul de moyenne avec le type double
        /*static void Main(string[] args)
        {
            List<double> notes = new List<double>();
            List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6 };
            double result = 0;
            Console.WriteLine("Veuillez entrer le nombre de notes");
            var nbrenote = int.Parse(Console.ReadLine());

            for (int i = 0; i < nbrenote; i++)
            {
                Console.WriteLine("Entrer une note");
                var not = Console.ReadLine();
                var note = Convert.ToDouble(not);
                notes.Add(note);
            }

            foreach (var item in notes)
            {
                result += item;

            }
            var resula = result / nbrenote;
            Console.WriteLine(resula);

        }*/
        #endregion

        #region Algo 1 systeme de calcule de date de naissance
        /*static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer votre age ");
            var age = int.Parse(Console.ReadLine());
            var date = DateTime.Now.Year;
            var annenaissance = date - age;
            if (annenaissance < date)
                Console.WriteLine(string.Format("L'utilisateur {0} a {1}", Environment.UserName, age));
            else
                Console.WriteLine(string.Format("Votre age ne peut pas etre {0}", age));
        }*/

        #endregion

        #region recencement de poche de sang urgent 
        /*static void Main(string[] args)
        {
            List<string> recences = new List<string>();
            List<string> sanguin = new List<string>() { "A", "B", "AB", "O" };
            var count = 0;
            var position = 1;
            Console.WriteLine("Entrer le groupe du patient ");
            var groupe = Console.ReadLine().ToUpper();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(string.Format("Le groupe du recencé {0} est:", i));
                var recencé = Console.ReadLine().ToUpper();
                foreach (var sang in sanguin)
                {
                    if (sang == recencé)
                        recences.Add(recencé);
                    else
                        Console.WriteLine(string.Format("Le groupe du recencé {0} n'existe pas", i));
                }

            }
            foreach (var item in recences)
            {

                if (item == groupe)
                {
                    count += 1;
                }
                if (count == 5)
                {
                    Console.WriteLine(string.Format("Le nombre de poches recencées est de 5 et la derniere poche du groupe {0} etait du recencé {1}", item, position));
                    break;
                }

                position++;
            }

        }*/
        #endregion

        #region Algo de classement 
        /*static void Main(string[] args)
        {
            var random = new Random();
            var random1 = random.Next(1, 20);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BIenvenue dans le jeu de dévinette ; veuillez deviner le nombre derriere la facette ");
            Console.ResetColor();


            var i = 1;
            while (i <= 10)
            {
                var utilisateur = int.Parse(Console.ReadLine());
                if (i == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dommage c'etait simple le nombre etait {0} n'hesitez pas a revenir jouer", random1);
                    Console.ResetColor();
                } 

                    if (utilisateur == random1)
                    {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bravo vous avez su deviner le nombre il était bien {0}", random1);
                    Console.ResetColor();
                    break;
                }

                    else if (utilisateur > (random1 + 5))
                    {
                        Console.WriteLine("Trop grand vous etes loin de trouver ; {0} chances epuisés", i);
                    }
                                                
                    else if (utilisateur < (random1 - 5))
                    {
                        Console.WriteLine("Trop pétit vous etes loin de trouver ;  {0} chances epuisés", i);
                    }
                        
                    else if (utilisateur > (random1 + 5) && (utilisateur < (random1 + 5)))
                    {
                        Console.WriteLine("Proche du nombre essayez a nouveau ; {0} chances epuisés", i);
                    }
                        
                    else if (utilisateur > (random1 - 5) && (utilisateur < (random1 - 5)))
                    {
                        Console.WriteLine("Proche du nombre essayez a nouveau; {0} chances epuisés", i);
                    }
                    else
                    {
                    Console.WriteLine("Veuillez reessayer s'il vous plait ;{0} chances epuisés", i);
                    }
                       

                i++;
                
            }

            
        }*/
        #endregion

        #region Algo De recceuil d'heure de bus 
        static void Main(string[] args)
        {
            List<int> heures = new List<int>();
            var total = 0;
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("Entrer l'heure du passage {0}",i);
                Console.ForegroundColor = ConsoleColor.Cyan;
                var hr = int.Parse(Console.ReadLine());
                Console.ResetColor();
                heures.Add(hr);
            }
            foreach (var item in heures)
            {
                total += item;
            }
            var reveil = (total / 6) - 1;
            if ((reveil + 2) < 8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Le reveil sera a {0}h et il sera a l'heure aux cours ", reveil);
                Console.ResetColor();
            }
            else if ((reveil + 1) >= 8)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Le reveil sera a {0}h et mais il sera en retard aux cours donc plus la peine d'y aller ", reveil);
                Console.ResetColor();
            }
           
        }
        #endregion

    }
}
