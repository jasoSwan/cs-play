using System;
using NCalc;

namespace Phys_Calc
{
    internal class Calculator
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            MainMenu();
        }

        private static void MainMenu()
        {
            bool exit = false;
            while (!exit)
            {
                try
                {
                    Console.Clear();
                    string choice;
                    Console.WriteLine("Choose an operation:");
                    Console.WriteLine("0)Basic Calculation ((),+,-,*,/)");
                    Console.WriteLine("e)Exit");
                    choice = Console.ReadLine();
                    switch (choice) /*Goes to method chosen by user*/
                    {
                        case "0":
                            Console.Clear();
                            BasicCalc();
                            break;
                        case "e":
                            exit = true;
                            break;
                        default:
                            Console.Write("Invalid Choice");
                            System.Threading.Thread.Sleep(500);
                            MainMenu();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error in method MainMenu: " + e);
                }
            }
        }

        private static void BasicCalc()
        {
            Console.Clear();
            Console.WriteLine("Basic Calculation");
            Console.WriteLine("Insert your operation (using +,-,*,/) :");
            try
            {
                string operation = "";
                operation = Console.ReadLine();
                Expression e = new Expression(operation);
                int i = (int)e.Evaluate();
                Console.WriteLine(operation + " = " + i);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Expression can only contain numbers, the symbols: (), +, -, *, /, and cannot be empty.");
            }
            Console.WriteLine("0)Another calculation");
            Console.WriteLine("b)Back");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "0":
                    BasicCalc();
                    break;
                case "b":
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice");
                    BasicCalc();
                    break;
            }
        }
    }
}