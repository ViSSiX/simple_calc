using System;
// by avmal0
// 128 lines of code | 15.01.21
// Uses Console. Simple and working.
// If you want to use calc or this code - it`s free. I don`t know why i said it. Ok.

namespace simple_calc
{
    class simple_calc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple calc. Uses double in math operations. Don`t use . in numbers, use ,");
            Console.WriteLine("Enter *, +, -, >, <, =, pow, pi or /. If you want check description, you can make it with [description]. ");
            object selection = Console.ReadLine(); // please to be accurate with selection
            switch (selection)
            {
                case "*": // 1 * 2
                    {
                        Console.WriteLine("you enter *");
                        Console.WriteLine("enter your 1 number: ");
                        double x_2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter your 2 number: ");
                        double y_2 = Convert.ToDouble(Console.ReadLine());
                        double result_2 = x_2 * y_2;
                        Console.WriteLine($"you get {result_2}");
                        goto case 9; // goto to close case
                    }
                case "/": // 1 / 2
                    {
                        Console.WriteLine("you enter /");
                        Console.WriteLine("enter your 1 number: ");
                        double x_1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter your 2 number: ");
                        double y_1 = Convert.ToDouble(Console.ReadLine());
                        double result_1 = x_1 / y_1;
                        Console.WriteLine($"you get {result_1}");
                        goto case 9; // goto to close case
                    }
                case "+": // 1 + 2
                    {
                        Console.WriteLine("you enter +");
                        Console.WriteLine("enter 1 number: ");
                        double x_3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter 2 number: ");
                        double y_3 = Convert.ToDouble(Console.ReadLine());
                        double result_3 = x_3 + y_3;
                        Console.WriteLine($"you get {result_3}");
                        goto case 9; // goto to close case
                    }
                case "-": // 1 - 2
                    {
                        Console.WriteLine("you enter -");
                        Console.WriteLine("enter 1 number: ");
                        double x_4 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter 2 number: ");
                        double y_4 = Convert.ToDouble(Console.ReadLine());
                        double result_4 = x_4 - y_4;
                        Console.WriteLine($"you get {result_4}");
                        goto case 9; // goto to close case
                    }
                case "pow": // 1^2
                    {
                        Console.WriteLine("you enter pow");
                        Console.WriteLine("enter your number: ");
                        double x_6 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter second: ");
                        double y_6 = Convert.ToDouble(Console.ReadLine());
                        double result_6 = Math.Pow(x_6, y_6);
                        Console.WriteLine($"you get {result_6}");
                        goto case 9; // goto to close case
                    }
                case "=": // 1 == 2
                    {
                        goto case "<";
                    }
                case ">": // 1 > 2 check
                    {
                        goto case "<"; // goto to case <
                    }
                case "<": // 1>2, 1<2, or 1=2
                    {
                        Console.WriteLine("you enter >, < or =. ok");
                        Console.WriteLine("enter 1 number: ");
                        double x_5 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter 2 number: ");
                        double y_5 = Convert.ToDouble(Console.ReadLine());
                        if (x_5 > y_5) // check your number
                        {
                            Console.WriteLine($"{x_5} > {y_5}");
                        }
                        else if (x_5 < y_5)
                        {
                            Console.WriteLine($"{x_5} < {y_5}");
                        }
                        else
                        {
                            Console.WriteLine($"{x_5} = {y_5}");
                        }
                        goto case 9;
                    }
                case 9:
                    {
                        Console.WriteLine("it's end, you can exit. Press any key to continue...");
                        Console.ReadLine();
                        return;
                    }
                case "pi": // debug PI number
                    {
                        double pi_1 = Math.PI;
                        Console.WriteLine($"you get {pi_1}");
                        goto case 9;
                    }
                case "description": // write description
                    {
                        Console.WriteLine("you enter description. good.");
                        Console.WriteLine("Description: you can use this program for math operations. You enter *, for example, and give to program numbers to calculate [1 * 2]. ");
                        Console.WriteLine("You want exit program or check other operations? Enter N if you don`t want it. Y for check another items");
                        goto case 9;
                    }

                default:
                    {
                        Console.WriteLine("please, restart program and choose correct operation");
                        return;
                    }

            }
        }
    }
}