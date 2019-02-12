using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int val_a = 10;
            int input_add1, input_add2, resulte_add;
            int number_of_players_int;
            string number_of_players_str;
            string user_input_add1, user_input_add2;
            string char_a = "Im a string 123";
            string hello = ("Hello World! \n");
            DateTime Date = DateTime.Now;
            ConsoleKeyInfo cki1;

            /*
             Hvilket progam vil du gerne køre:
             Dice Game
             Hello Everything
             etc....
             Kør alt fra hver sin fil/classe
             Console.Clear()
             Console.TreatControlCAsInput = true;
             */
            
            //Hello World
            Console.Write(hello);
            Console.WriteLine("The date is " + Date.ToLongDateString());
           
            //String and int
            Console.Write("This is all on ");
            Console.Write("one line \n");
            Console.WriteLine("And i can write number from an int like this: {0} " +
                "\nand leters and nubers from the varibel string like this: {1} ", val_a, char_a);
            
            // Add numbers and user input
            Console.WriteLine("I can even add numbers togethere, so give me the first whole number:");
            user_input_add1 = Console.ReadLine();
            input_add1 = Int32.Parse(user_input_add1);

            Console.WriteLine("And then the second whole number");
            user_input_add2 = Console.ReadLine();
            input_add2 = Int32.Parse(user_input_add2);

            Console.Write("Prossesing");

             for (int i = 0; i <= 2; i++)
             {
                 System.Threading.Thread.Sleep(600);
                 Console.Write(".");
             }
            resulte_add = input_add1 + input_add2;
            Console.WriteLine("\nResulte = "+resulte_add);

            // Dice Game
            Console.WriteLine("Now that i have showne that i can add numbers together want to give it a twist whit a dice game? [Y] or [N] ");
            cki1 = Console.ReadKey(true);
            do
            {
                Console.WriteLine("How many are playing?");
                number_of_players_str = Console.ReadLine();
                number_of_players_int = Int32.Parse(number_of_players_str);

                int a = 0;
                string[] player_name = new string[number_of_players_int];
                for (int i = number_of_players_int; i > 0; i--)
                {
                    Console.WriteLine("Player {0} name is:", a+1);
                    player_name[a] = Console.ReadLine();
                    a++;
                }
        
                if (number_of_players_int == 2)
                {
                    Console.WriteLine("So {0} is playing agains {1}", player_name[1], player_name[0]);
                }
                else
                {
                    Console.Write("So ");
                    for (int i = a; i > 1; i--)
                    {
                        a--;
                        Console.Write("{0}, ", player_name[a]);
                    }
                    a--;
                   Console.Write("and {0} is playing agains eatch othere\n", player_name[a]);
                }
               
                Console.WriteLine("Do you want to play again [Y] or [N]");
                cki1 = Console.ReadKey(true);
            } while (cki1.Key != ConsoleKey.N);
        }
    }
}
