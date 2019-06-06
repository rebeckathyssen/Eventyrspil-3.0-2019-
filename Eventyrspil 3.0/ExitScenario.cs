using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventyrspil_3._0
{
    class ExitScenario : Scenario
    {
        public ExitScenario(string FileName) : base(FileName)
        {
            sceneType = 6;
        }

        public override void Action()
        {
            Console.WriteLine(currentChoice);
            Console.ReadKey();           
            Environment.Exit(0);
        }
    }
}
