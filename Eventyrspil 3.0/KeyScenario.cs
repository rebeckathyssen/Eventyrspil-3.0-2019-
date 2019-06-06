using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventyrspil_3._0
{
    class KeyScenario : Scenario
    {
        // ITEM = 3


        public KeyScenario(string FileName) : base(FileName)
        {
            sceneType = 3;
        }


        public override void Action()
        {
            Console.WriteLine(currentChoice);
            currentChoice = currentChoice.makeChoice(0);        // Husk at vi altid starter på 0, for nyt objekt = ny liste :)


            Player.keys.Add(new Key() { KeyId = 1 });           // den får lige et ID i tilfælde af at vi skal bruge det til noget senere...
                                
            
            Console.ReadKey();
            Console.Clear();
                        
        }
    }
}
