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
        static void Main(string[] args)
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

        }
        #endregion





    }
}
