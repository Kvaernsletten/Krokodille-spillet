using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvaernsletten
{
    internal class Croc
    {
        public int score = 0;
        public bool gameStarted = false;
        public bool correct = false;
        public void Run()
        {
            if (gameStarted)
            {
                if (correct)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                    score--;
                }
            }

            int number1 = generateNumber1();
            int number2 = generateNumber2();  
            Console.WriteLine("Your score: " + score);
            Console.WriteLine();
            Console.WriteLine(number1 + " ? " + number2);
            
            var input = Console.ReadLine();

            switch (input)
            {
                case "<":
                    if (number1 < number2)
                    {
                        correct = true;
                    }
                    else
                    {
                        correct = false;
                    }
                    break;
                case ">":
                    if (number1 > number2)
                    {
                        correct = true;
                    }
                    else
                    {
                        correct = false;
                    }
                    break;
                case "=":
                    if (number1 == number2)
                    {
                        correct = true;
                    }
                    else
                    {
                        correct = false; 
                    }
                    break;
            default:
                Console.WriteLine("Not a valid answer!");
                    Console.WriteLine("Your final score is: " + score);
                    return;
            }
            gameStarted = true;
            Console.Clear();
            Run();
        }


        public int generateNumber1()
        {
            Random random = new Random();
            int num = random.Next(1, 12);
            return num;
        }

        public int generateNumber2()
        {
            Random random = new Random();
            int num = random.Next(1, 12);
            return num;
        }
    }
}

