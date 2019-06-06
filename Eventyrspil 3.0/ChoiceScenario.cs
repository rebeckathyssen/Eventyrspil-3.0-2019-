using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventyrspil_3._0
{
    class ChoiceScenario : Scenario
    {
        // CHOICE = 1
        public ChoiceScenario(string FileName) : base(FileName)
        {
            sceneType = 1;
        }

        int userChoice;

        public override void Action()
        {
            Console.WriteLine(currentChoice);

            MakeChoice(out userChoice);
            switch (userChoice)
            {
                case 1:

                    currentChoice = currentChoice.makeChoice(0); 
                    Console.Clear();
                    break;

                case 2:

                    currentChoice = currentChoice.makeChoice(1);
                    Console.Clear();
                    break;

                default:
                    break;
            }
        }

        static void MakeChoice(out int choice)
        {
            choice = 0;
            while (choice == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Vælg mulighed 1 eller 2.");
                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                    if (choice > 2 || choice < 0)
                        choice = 0;
                }
                catch (Exception)  // i gamle dage stod der "Exception e" her 8-)
                {
                    Console.WriteLine("Du skal vælge mulighed 1 eller 2.");
                }
            }
        }
    }
}
