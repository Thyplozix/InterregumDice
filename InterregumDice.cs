using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterregumDice
{
    class Program
    {
       

            static void Main(string[] args)
        {
            Random randomDiceRoll = new Random();
            int randomNumber;
            randomNumber = randomDiceRoll.Next(0, 7);

            Console.WriteLine("How many dice would you like to roll today?");
            var input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)   
                {
                Console.WriteLine(randomNumber);
                randomNumber = randomDiceRoll.Next(0, 7);
                }

            Console.ReadLine();
        }
    }
}

    