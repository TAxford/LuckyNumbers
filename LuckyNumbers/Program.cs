using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int UsersLowestNum;
            int UsersHighestNum;
            int matches = 0;
            int LuckyJackpot = 777777777;
            int reward = matches + LuckyJackpot;
            

            Console.WriteLine("Welcome to LuckyNumbers, the Game where you can win " + "$" + LuckyJackpot + " dollars " + " please press enter to start! ");
            Console.ReadLine();

            Console.WriteLine("Please choose your lowest starting number");//user chooses starting point to lottery numbers
            UsersLowestNum = int.Parse(Console.ReadLine());//user input for lowest
            int start = UsersLowestNum;//sets users lowest to start variable

            Console.WriteLine("Please choose your highest end number");//user chooses finiishing point to lottery numbers
            UsersHighestNum = int.Parse(Console.ReadLine());//user input for highest
            int finish = UsersHighestNum;//sets users highest to finish varuable

            Console.WriteLine("Please enter your 6 lucky numbers");//asking user to chose 6 numbers

            int[] UserLuckyNums = new int[6];

            for (int i = 0; i < UserLuckyNums.Length; i++)
            {
                UserLuckyNums[i] = int.Parse(Console.ReadLine());

                if ((UserLuckyNums[i] < UsersLowestNum) || (UserLuckyNums[i] > UsersHighestNum))
                {
                    Console.WriteLine("You have input a wrong number, Please chose again");
                    Console.ReadLine();
                }

            }


            Random r = new Random();//starts the random generator for lucky winning numbers

            int[] LuckyGameNum = new int[6];

            for (int i = 0; i < LuckyGameNum.Length; i++)
            {
                LuckyGameNum[i] = r.Next(UsersLowestNum, UsersHighestNum);
                Console.WriteLine("Lucky Number: " + LuckyGameNum[i]);//displays the Winning numbers

            }

            for (int i = 0; i < UserLuckyNums.Length; i++)
            {
                for (int j = 0; j < LuckyGameNum.Length; j++)
                {
                    if (UserLuckyNums[i] == LuckyGameNum[j])
                        matches = matches + 1;
                }
            }

            Console.WriteLine("You have won " + reward);
          
            {
                Console.Write("Do you want to play again [Yes or No]?");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Yes")
                    return;
                if (answer == "No")
                {
                    Console.WriteLine("Thanks for playing!");
                }
            }
















        }


    }
}
