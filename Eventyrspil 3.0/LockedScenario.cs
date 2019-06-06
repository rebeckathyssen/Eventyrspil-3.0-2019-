using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventyrspil_3._0
{
    class LockedScenario : Scenario
    {
        // LOCKED = 5
        public LockedScenario(string FileName) : base(FileName)
        {
            sceneType = 5;
        }

        public override void Action()
        {

            int countKeys = Player.keys.Count;                          // tjekker om der overhovedet findes nogen nøgler i vores list
                                                                        // ja = videre til næste scene, nej = tilbage til anden scene
            if (countKeys > 0)
            {
                Console.WriteLine(currentChoice);
                currentChoice = currentChoice.makeChoice(0);
                Console.ReadKey();
                Console.WriteLine("Du har heldigvis en nøgle, og kan låse dig ind!");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine(currentChoice);
                currentChoice = currentChoice.makeChoice(1);
                Console.ReadKey();
                Console.WriteLine("\nÅh nej, du har ingen nøgler, og du må prøve den lilla dør i stedet!\n " +
                    "Tryk på en tast for at gå ind ad den lilla dør...");
                Console.ReadKey();
                Console.Clear();
            }                       
        }
    }
}
