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
            int UserLuckyNum;

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
                UserLuckyNum = int.Parse(Console.ReadLine());
            }





































































        }
    }
}
