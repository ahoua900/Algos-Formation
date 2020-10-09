using System;
using System.Collections.Generic;

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{

			List<string> wordsList = new List<string> { "ANANAS", "AMOUR", "HAINE", "SOLITUDE", "REGRET", "PASSION", "ORANGE", "VOITURE", "EXPLORATION", "VIOLATION", "OEUF", "GARBA", "IGNAME", "CONSTITUTIONNEL", "MAUVAIS" };
            var vide = '*';
            List<char> reponse = new List<char>();
			var randon = new Random();
			var swith = randon.Next(0, wordsList.Count);
            var hasard = wordsList[swith];
            Console.WriteLine(hasard);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Trouvez le mot selectionné chance {0}", i);

                var mot = Console.ReadLine();
                foreach (var item in hasard)
                {
                    foreach (var it in mot)
                    {
                        if (item == it)
                        {
                            reponse.Add(it);
                            foreach (var b in reponse)
                            {
                                Console.WriteLine("{0}", b);
                            }
                        }
                        else
                        {
                            reponse.Add(vide);
                            foreach (var b in reponse)
                            {
                                Console.WriteLine("{0}", b);
                            }
                        }
                        reponse.Clear();
                        break;
                    }
                }                
            }

		}
	}
}
