using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventyrspil_3._0
{
    class LifeScenario : Scenario
    {
        public LifeScenario(string FileName) : base(FileName)
        {
            sceneType = 4;
        }

        public override void Action()
        {
            Console.WriteLine(currentChoice);
            currentChoice = currentChoice.makeChoice(0);                     

            Player.lives.Add(new Life());
            Player.lives.Add(new Life());
            Player.lives.Add(new Life());
                        
            Console.ReadKey();
            Console.Clear();            
        }                
    }
}
