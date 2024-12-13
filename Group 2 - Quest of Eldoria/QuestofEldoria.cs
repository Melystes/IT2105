using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game();
        }
        
        static void Game()
        {
        bool restart = true;

        while (restart)
        {
            int score = 0;

            //Start
            Console.WriteLine("Welcome to The Quest of Eldoria - Short Adventure!\n");

            score = Lv1();

            if (score == -1)
            {
                Console.WriteLine("\nDo you want to restart the game? (yes/no)");
                string restartChoice = Console.ReadLine();

                if (restartChoice.ToLower() == "no")
                {
                    Console.WriteLine("\nThank you for playing The Quest of Eldoria!");
                    Console.ReadKey();
                    restart = false;
                }
            }
            else
            {
                score = Lv2(score);

                if (score == -1)
                {
                    Console.WriteLine("\nDo you want to restart the game? (yes/no)");
                    string restartChoice = Console.ReadLine();

                    if (restartChoice.ToLower() == "no")
                    {
                        Console.WriteLine("\nThank you for playing The Quest of Eldoria!");
                        Console.ReadKey();
                        restart = false;
                    }
                }
                else
                {
                    score = FinalChoice(score);
                    Console.Clear();
                    Console.WriteLine("\nYour final score: " + score);

                    // Determine the ending based on the final score
                    if (score >= 10)
                    {
                        Console.WriteLine("\nCongratulations! You have achieved a high score and brought peace to Eldoria with your wise choices.");
                    }
                    else if (score >= 5)
                    {
                        Console.WriteLine("\nYou have completed the quest with some success, but challenges may lie ahead for Eldoria.");
                    }
                    else
                    {
                        Console.WriteLine("\nYour choices have led to turmoil in Eldoria. The consequences of your actions may haunt the land.");
                    }

                    Console.WriteLine("\nDo you want to restart the game? (yes/no)");
                    string restartChoiceFinal = Console.ReadLine();

                    if (restartChoiceFinal.ToLower() == "no")
                    {
                        Console.WriteLine("\nThank you for playing The Quest of Eldoria!");
                        Console.ReadKey();
                        restart = false;
                    }
                }
            }
        }
    }

        static int Lv1()
        {
            int score = 0;
            //Lv 1 Start
            Console.WriteLine("Level 1: The Village of Whisperwind\n");
            Console.WriteLine("You are in Whisperwind, a peaceful village on the edge of Eldoria. A hooded figure approaches you in the bustling marketplace. They reveal that an ancient relic has been stolen by a rogue sorcerer and beg for your help to retrieve it.\n");

            Console.WriteLine("Choices:");
            Console.WriteLine("1. Accept the quest and travel to the Dark Forest.");
            Console.WriteLine("2. Decline the quest and remain in the village.\n");

            Console.Write("Enter your choice (1 or 2): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    score += 5;
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("\nYou decline the quest and remain in the village. The story ends here.\n");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return -1;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nInvalid choice. Game over.\n");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return -1;
            }
            return score;
        }

    static int Lv2(int score)
    {
        //Lv 2 Start
        Console.Clear();
        Console.WriteLine("\nLevel 2: The Sorcerer’s Tower\n");
        Console.WriteLine("You arrive at the Sorcerer’s Tower after braving the forest. The air crackles with magic. Inside, the sorcerer confronts you, the relic glowing ominously in their hands.\n");

        Console.WriteLine("Choices:");
        Console.WriteLine("1. Negotiate with the sorcerer.");
        Console.WriteLine("2. Engage in battle to retrieve the relic.");
        Console.WriteLine("3. Attempt to steal the relic using stealth.\n");

        Console.Write("Enter your choice (1, 2, or 3): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
        case "1":
            score += 3;
            Console.WriteLine("\nYou successfully negotiate with the sorcerer. They explain their motives, leading to a peaceful resolution.\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            break;
        case "2":
            score += 2;
            Console.WriteLine("\nA fierce battle breaks out. You manage to retrieve the relic but at a great cost.\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            break;
        case "3":
            score += 1;
            Console.WriteLine("\nYou steal the relic using stealth, but your actions have unforeseen consequences later.\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            break;
        default:
            Console.Clear();
            Console.WriteLine("\nInvalid choice. Game over.\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return -1;
        }
    return score;
    }

    static int FinalChoice(int score)
    {
        //Ending Start
        Console.Clear();
        Console.WriteLine("\nEnding\n");
        Console.WriteLine("If you succeed in obtaining the relic, you return to Whisperwind.\n");

        Console.WriteLine("Player’s Final Choice:");
        Console.WriteLine("1. Use the relic to restore peace to Eldoria.");
        Console.WriteLine("2. Keep the relic for personal gain.");
        Console.WriteLine("3. Destroy the relic to end its influence forever.\n");

        Console.Write("Enter your final choice (1, 2, or 3): ");
        string finalChoice = Console.ReadLine();

        switch (finalChoice)
        {
            case "1":
                score += 5;
                Console.WriteLine("\nYou use the relic to restore peace to Eldoria. Congratulations, you have completed The Quest of Eldoria!\n");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
            case "2":
                score += 2;
                Console.WriteLine("\nYou keep the relic for personal gain. The consequences of your choice are yet to be seen.\n");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
            case "3":
                score += 3;
                Console.WriteLine("\nYou destroy the relic to end its influence forever. The story concludes with your decisive action.\n");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
            default:
                Console.Clear();
                Console.WriteLine("\nInvalid choice. Game over.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return -1;
        }

        return score;
    }
  }
}