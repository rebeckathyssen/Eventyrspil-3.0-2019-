using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventyrspil_3._0
{
    class Program
    {
        // I DENNE VERSION:
        // - refaktorerer vi hele spillet til at kunne læses fra en database. V. 2.1 er låst af en LeftScene/RightScene. Disse proporties slettes
        // og i stedet tilføjes alle objekter til en liste, hvor vi så i de enkelte underklasser kan vælge at pege på et bestemt index (scenario) i den
        // liste i stedet for at pege på en LeftScene/RightScene. Det betyder, at det nu er meganemt at tilføje en ny underklasse hvis vi vil, som kan
        // have f.eks. 4 forskellige muligheder - nord/syd/øst/vest, idet vi med vores nye metoder kan binde listen af objekter sammen på lige den måde
        // vi ønsker det :)
        static void Main(string[] args)
        {           
            // Vi skal altså, indtil videre, stadig indlæse alle vores objekter

            ChoiceScenario Intro = new ChoiceScenario("intro.txt");

            ChoiceScenario Forside = new ChoiceScenario("forside.txt");

            ChoiceScenario Scen1a = new ChoiceScenario("1a.txt");
            ChoiceScenario Scen1b = new ChoiceScenario("1b.txt");

            RandomScenario Scen2a = new RandomScenario("2a.txt");
            RandomScenario Scen2b = new RandomScenario("2b.txt");

            ChoiceScenario Scen3a = new ChoiceScenario("3a.txt");
            ChoiceScenario Scen3b = new ChoiceScenario("3b.txt");

            LockedScenario Scen4a = new LockedScenario("4a.txt");
            ChoiceScenario Scen4b = new ChoiceScenario("4b.txt");

            ChoiceScenario Scen5a = new ChoiceScenario("5a.txt");
            RandomScenario Scen5b = new RandomScenario("5b.txt");
            RandomScenario Scen5c = new RandomScenario("5c.txt");

            RandomScenario Scen6a = new RandomScenario("6a.txt");
            RandomScenario Scen6b = new RandomScenario("6b.txt");
            ChoiceScenario Scen6c = new ChoiceScenario("6c.txt");
            ChoiceScenario Scen6d = new ChoiceScenario("6d.txt");

            ChoiceScenario Scen7a = new ChoiceScenario("7a.txt");
            ChoiceScenario Scen7b = new ChoiceScenario("7b.txt");
            KeyScenario Scen7c = new KeyScenario("7c.txt");
            RandomScenario Scen7d = new RandomScenario("7d.txt");

            ChoiceScenario Scen8a = new ChoiceScenario("8a.txt");
            ChoiceScenario Scen8b = new ChoiceScenario("8b.txt");            

            LifeScenario Scen9a = new LifeScenario("9a.txt");
            RandomScenario Scen9b = new RandomScenario("9b.txt");

            ChoiceScenario Scen10a = new ChoiceScenario("10a.txt");
            LifeScenario Scen10b = new LifeScenario("10b.txt");

            ChoiceScenario Scen11a = new ChoiceScenario("11a.txt");

            RandomScenario Scen12a = new RandomScenario("12a.txt");
            RandomScenario Scen12b = new RandomScenario("12b.txt");

            ChoiceScenario Scen13a = new ChoiceScenario("13a.txt");

            ChoiceScenario Scen13b = new ChoiceScenario("13b.txt");

            ExitScenario Exit = new ExitScenario("exit.txt");

            ChoiceScenario GameOver = new ChoiceScenario("gameover.txt");
                        
            Player player = new Player();


            // Herunder binder vi dem sammen via addChoice-metoden. Denne putter altså objekterne ind på deres respektive pladser i vores liste.
            // HUSK AT for HVERT NYT OBJEKT laves en NY LISTE (se scenario-constructor)! Dvs. når vi nu tager Forside og tilføjer Scen1a - så er det
            // KUN Scen1a der står på Forsides liste! Så når vi laver Scen1a får denne også sin egen liste, og her tilføjer vi Scen2a og Scen2b, dvs. på Scen1a's
            // liste findes KUN to elementer! 

            Intro.addChoice(Forside);
            Intro.addChoice(Exit);

            Forside.addChoice(Scen1a);
            Forside.addChoice(Scen1b);

            Scen1a.addChoice(Scen2a);
            Scen1a.addChoice(Scen2b);

            Scen1b.addChoice(Scen2a);
            Scen1b.addChoice(Scen2b);

            Scen2a.addChoice(Scen3a);
            
            Scen2b.addChoice(Scen3b);

            Scen3a.addChoice(Scen4a);
            Scen3a.addChoice(Scen4b);

            Scen3b.addChoice(Scen4a);
            Scen3b.addChoice(Scen4b);

            Scen4a.addChoice(Scen5a);
            Scen4a.addChoice(Scen4b);

            Scen4b.addChoice(Scen5b);
            Scen4b.addChoice(Scen5c);

            Scen5a.addChoice(Scen6a);
            Scen5a.addChoice(Scen6b);

            Scen5b.addChoice(Scen6c);

            Scen5c.addChoice(Scen6d);

            Scen6a.addChoice(Scen7a);

            Scen6b.addChoice(Scen7b);

            Scen6c.addChoice(Scen7c);
            Scen6c.addChoice(Scen7d);

            Scen6d.addChoice(Scen7c);
            Scen6d.addChoice(Scen7d);

            Scen7a.addChoice(Scen8a);
            Scen7a.addChoice(Scen8b);

            Scen7b.addChoice(Scen8a);
            Scen7b.addChoice(Scen8b);

            Scen7c.addChoice(Scen4a);

            Scen7d.addChoice(Scen7c);

            Scen8a.addChoice(Scen9a);
            Scen8a.addChoice(Scen9b);

            Scen8b.addChoice(Scen9a);
            Scen8b.addChoice(Scen9b);

            Scen9a.addChoice(Scen10a);

            Scen9b.addChoice(Scen10b);

            Scen10a.addChoice(Scen12a);
            Scen10a.addChoice(Scen12b);

            Scen10b.addChoice(Scen11a);

            Scen11a.addChoice(Scen12a);
            Scen11a.addChoice(Scen12b);

            Scen12a.addChoice(Scen13a);

            Scen12b.addChoice(Scen13b);

            Scen13a.addChoice(Intro);
            Scen13a.addChoice(Exit);

            Scen13b.addChoice(Intro);
            Scen13b.addChoice(Exit);

            GameOver.addChoice(Intro);
            GameOver.addChoice(GameOver);

            


            Scenario.currentChoice = Intro;

            Player.lives.Add(new Life());
            Player.lives.Add(new Life());
            Player.lives.Add(new Life());                       

            while (true)
            {
                Console.WriteLine("Liv: " + Player.lives.Count + "          " + "Nøgler: " + Player.keys.Count + "\n");
                               
                switch (Scenario.currentChoice.sceneType)
                {
                    case 1:
                        Scen1a.Action();
                        break;

                    case 2:
                        
                        Scen2a.Action();
                        if (Player.lives.Count == 0)
                        {
                            Scenario.currentChoice = GameOver;              // vil egentligt gerne have flyttet det her - men hvordan peger jeg på "gameover" fra de andre klasser?
                            Console.WriteLine(Scenario.currentChoice);
                            Console.ReadKey();
                            Console.Clear();
                            Scenario.currentChoice = Intro;
                            Player.lives.Add(new Life());
                            Player.lives.Add(new Life());
                            Player.lives.Add(new Life());
                        }
                        break;

                    case 3:
                        Scen7c.Action();
                        break;

                    case 4:
                        Scen9a.Action();
                        break;

                    case 5:
                        Scen4a.Action();
                        break;

                    case 6:
                        Exit.Action();
                        break;                 

                    default:
                        Console.WriteLine("Åh nej, noget gik galt!");
                        break;
                }
            }
        }
    }
}
