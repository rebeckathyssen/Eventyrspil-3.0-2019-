using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventyrspil_3._0
{
    class Scenario
    {
        // DATAMEMBERS
        public string SceneText { get; set; }

        public int sceneType { get; set; }

        static public Scenario currentChoice { get; set; }
                
        List<Scenario> choices { get; set; }            // Her laver vi en liste, som hedder "choices". 



        // CONSTRUCTOR
        public Scenario(string FileName)
        {
            SceneText = ReadFromFile(FileName);
            choices = new List<Scenario>();             // Listen sættes ind i vores constructor, således at der ALTID laves en NY liste, hver gang et nyt objekt laves
        }

        // METHODS
        public string ReadFromFile(string fileName)
        {
            string contents = File.ReadAllText(fileName, Encoding.GetEncoding("iso-8859-1"));
            return contents;
        }


        public virtual void Action()
        {
            Console.WriteLine(SceneText);
        }
        
        
        public void addChoice(Scenario scenario)        // Denne metode tager et "scenario" af typen Scenario og putter det ind i listen "choices"
        {
            choices.Add(scenario);
        }

    
        public Scenario makeChoice(int index)           // I denne metode kan vi indtaste en int - den indtastede int svarer til indexet i vores liste "choices".
        {                                               // Dvs. taster vi 1, så vil den returnere det objekt, som ligger på index 1 i vores liste. (Eller 0, hvis man som bruger
            return choices[index];                      // kun kan vælge mellem 1 eller 2. Så vil 1 selvfølgelig være 0, og 2 vil være 1.)
        }

        
        public override string ToString()
        {
            return SceneText;
        }

    }
}
