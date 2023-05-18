using System;

namespace ConsoleApp1
{
    class Calculator
    {
        private double num1;
        private double num2;
        string op;
        
        double ReadNum(int num = 0)
        {
            while (true)
            {
                try
                {
                    Console.Write("Number" + (num == 0 ? "" : num.ToString()) + " = ");
                    return double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("please input number");
                }
            }
        }
        void PrintAnswser(double ans)
        {
            Console.WriteLine("Answer is " + ans);
        }
        public void Start()
        {
            bool calcLoop = true;
            while (calcLoop)
            {
                bool readLoop = true;
                while (readLoop)
                {
                    readLoop = false;
                    Console.WriteLine("\n--------------------\n");
                    Console.WriteLine("Please input operators:\n");
                    Console.WriteLine("\t^  power");
                    Console.WriteLine("\t+  plus");
                    Console.WriteLine("\t-  minus");
                    Console.WriteLine("\t*  multiply");
                    Console.WriteLine("\t/  divide");
                    Console.WriteLine("\ts  square root");
                    Console.WriteLine("\tc  cube root");
                    Console.WriteLine("\tg  10 based log");
                    Console.WriteLine("\tn  e based log");
                    Console.WriteLine("\te  exit");
                    op = Console.ReadLine();
                    if (op == "+" || op == "-" || op == "*" || op == "/" || op == "^")
                    {
                        num1 = ReadNum(1);
                        num2 = ReadNum(2);
                        switch(op)
                        {
                            case "+":
                                PrintAnswser(num1 + num2);
                                break;
                            case "-":
                                PrintAnswser(num1 - num2);
                                break;
                            case "*":
                                PrintAnswser(num1 * num2);
                                break;
                            case "/":
                                while (num2 == 0) 
                                { 
                                    Console.WriteLine("\nCannot divide by zero! Please try again");
                                    num2 = ReadNum(2);
                                }
                                PrintAnswser(num1 / num2);
                                
                                break;
                            case "^":
                                PrintAnswser(Math.Pow(num1, num2));
                                break;
                            default:
                                Console.WriteLine("Unknown Error 1");
                                break;
                        }
                    }
                    else if (op == "s" || op == "c" || op == "g" || op == "n")
                    {
                        num1 = ReadNum();
                        switch(op) 
                        {
                            case "s":
                                PrintAnswser(Math.Sqrt(num1));
                                break;
                            case "c":
                                PrintAnswser(Math.Pow(num1, 1 / 3.0f));
                                break;
                            case "g":
                                PrintAnswser(Math.Log10(num1));
                                break;
                            case "n":
                                PrintAnswser(Math.Log(num1));
                                break;
                            default:
                                Console.WriteLine("Unknown Error 2");
                                break;
                        }
                    }
                    else if (op == "e")
                    {
                        calcLoop = false;
                    }
                    else
                    {
                        readLoop = true;
                        Console.WriteLine("please input correct operator");
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcone to C# console calculator");
            Calculator calc = new Calculator();
            calc.Start();
        }
    }
}