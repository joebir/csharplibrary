using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0._13_OOP_BuildAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            //Prompt for player information
            Console.WriteLine("Hello, wanderer...\n" +
                "What is your name?");
            string inputName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Nice to meet you, {inputName}.");
            Thread.Sleep(1000);

            Console.WriteLine("\nWhat's your specialization friend?\n" +
                "0: Horse Mange\n" +
                "1: Troll Cat\n" +
                "2: Knight Templator\n" +
                "3: Demogorg\n" +
                "4: Vampire\n" +
                "5: Bovine Frog");
            //Get value user provided
            int inputSpec = Int32.Parse(Console.ReadLine());

            //perform explicit cast from
            //int to Specialization enum type
            Player.Specialization inputSpecialization = (Player.Specialization)inputSpec;

            Console.WriteLine($"Ah... a {inputSpecialization}, an interesting choice...");

            Player pc = new Player(inputName, inputSpecialization);

            Console.Clear();

            Console.WriteLine($"Your journey begins here, {pc.Name} the {pc.Role}");

            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("A shady figure appears...");
            Thread.Sleep(1500);

            Console.WriteLine($"You're going down, {pc.Role}.");
            synth.Speak($"You're going down, {pc.Role}.");
            Thread.Sleep(1000);

            Enemy rous = new Enemy("Giant Talking Rat", pc.Level);
            Console.WriteLine("BATTLE START!");
            synth.Speak("BATTLE START!");

            //Battle loop
            while (pc.IsAlive && rous.IsAlive)
            {
                Console.Clear();
                Console.WriteLine($"{pc.Name}'s health: {pc.Health}\n" +
                    $"{rous.Name}'s Health: {rous.Health}");
                Console.WriteLine("====================\n" +
                    "       ACTIONS       \n" +
                    "====================");
                Console.Write("0: Attack\n" +
                              "1: Run\n" +
                              "2: Hide\n");
                int inputAction = Int32.Parse(Console.ReadLine());
                Player.Action pcAction = (Player.Action)inputAction;

                switch (pcAction)
                {
                    case Player.Action.Attack:
                        int pcAttack = pc.Attack();
                        Thread.Sleep(500);
                        int rousAttack = rous.Attack();
                        pc.Health -= rousAttack;
                        rous.Health -= pcAttack;
                        Console.Clear();
                        Console.WriteLine("=======================\n" +
                                         $"{pc.Name} Deals {pcAttack} to {rous.Name}\n" +
                                          "=======================\n");
                        Thread.Sleep(1000);
                        Console.WriteLine("=======================\n" +
                                         $"{rous.Name} Deals {rousAttack} to {pc.Name}\n" +
                                          "=======================\n");
                        Thread.Sleep(1500);
                        break;

                    case Player.Action.Run:
                        Console.Clear();
                        Console.WriteLine($"{pc.Name} tries to make a run for it!");
                        Thread.Sleep(1500);
                        synth.Speak($"Where do you think you're going, {pc.Role}?!");
                        Console.Clear();
                        Console.WriteLine($"{rous.Name} pulls {pc.Name} back into the fight!");
                        break;

                    case Player.Action.Hide:
                        Console.Clear();
                        Console.WriteLine($"{pc.Name} attempts to hide...");
                        Thread.Sleep(1500);
                        synth.Speak($"You can't hide from me, {pc.Role}.");
                        Console.Clear();
                        Console.WriteLine($"{rous.Name} found {pc.Name}!");
                        break;

                    default:
                        Console.WriteLine("Enter 0, 1, or 2 to perform an action!");
                        synth.Speak("Hurry up, I have a hot date in the Fire Swamp in an hour!");
                        break;
                }
            }
        }
    }
}
