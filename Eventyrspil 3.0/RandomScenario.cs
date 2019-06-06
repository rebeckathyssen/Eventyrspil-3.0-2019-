using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventyrspil_3._0
{
    class RandomScenario : Scenario
    {
        // RANDOM = 2
        public RandomScenario(string FileName) : base(FileName)
        {
            sceneType = 2;
        }
               

        public override void Action()
        {            
            Console.WriteLine(currentChoice);
            Random random = new Random();
            int randomNumber;
            randomNumber = random.Next(1, 6);
            Console.ReadKey();
            Console.WriteLine("\nDu slog en " + randomNumber + "er!");                              
                      
            while (randomNumber < 1)
            {

                int totalLives = Player.lives.Count;
                if (totalLives < 1)
                {
                    Console.WriteLine("<Indsæt dramatisk DU-HAR-TABT-lyd her>");
                    Console.ReadKey(); 
                    
                    Console.Clear();
                    

                    break;
                }

                Console.WriteLine("Av! Det gik ikke så godt, og du mister et liv. Prøv igen!");
                Console.ReadKey();
                Console.Clear();
                Player.lives.RemoveAt(0);
                Console.WriteLine("Liv: " + Player.lives.Count + "          " + "Nøgler: " + Player.keys.Count + "\n");                                
                Console.WriteLine(currentChoice);
                randomNumber = random.Next(1, 6);
                Console.ReadKey();
                Console.WriteLine("\nDu slog en " + randomNumber + "er!");
            }

            if (randomNumber >= 2)
            {
                currentChoice = currentChoice.makeChoice(0);
                Console.WriteLine("Hurra! Det var højt nok til at det lykkedes! Tryk på en tast for at fortsætte...");
                Console.ReadKey();
                Console.Clear();
                                                             
            }
        }
    }
}
