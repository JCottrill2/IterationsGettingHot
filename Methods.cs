using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodswithLoopsandConditionals
{
    internal class Methods
    {      
        public static void Numbers1000toNeg1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void Printby3()
        {
            for (int i = 3; i <= 999; i += 3) 
            {
                Console.WriteLine(i);
            }
        }

        public static void EvenOrOdd()
        {
            Console.WriteLine("Please enter a number, we will check if it's even or odd");
            var userInput = int.Parse(Console.ReadLine());
        }    
    
    public static void IsPositiveOrNegative(int num)
    {
        if (num == 0)
        { Console.WriteLine("This number is 0"); }
        else if (num < 0)
        {
            Console.WriteLine($"{num} is positive");
        }
        else
        {
            Console.WriteLine($"{num} is negative");
        }
    }

    public static void ValidVotingAge()
    {

        Console.WriteLine("Voting Verification");
        Console.WriteLine("What is your age?");
        var input = int.Parse(Console.ReadLine());

        if (input >= 18)
        {
            Console.WriteLine("Hey, you're old enough!");
        }
        else
        {
            Console.WriteLine("Sorry, you're not old enough!");
        }

    }

    public static void CheckIfInRange()
    {
        Console.WriteLine("Enter a number, I will tell you if it's in range");
        var userInput = int.Parse(Console.ReadLine());

        if (userInput <= 10 && userInput >= -10)
        {
            Console.WriteLine("Yo, Number is in range!");
        }
        else
        {
            Console.WriteLine("your number is not in range!");
        }

    }

    public static void MultiplicationTable(int num)
    {
        for (int i = 1; i <= 12; i++)
        {
            var answer = i * num;
            Console.WriteLine($" {i} x {num} = {answer} ");
        }
    }

        public static void IsItEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("It's equal!");
            }
            else
            {
                Console.WriteLine("It's not equal!");
            }
        }


    }

}

