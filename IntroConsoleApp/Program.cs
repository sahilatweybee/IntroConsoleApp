using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IntroConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a non Zero integer a: ");
        Get_a:
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 0) {
                Console.Write("Number Should be Non Zero: ");
                goto Get_a; 
            }
            Console.Write("Enter a non Zero integer b: ");
        Get_b:
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                Console.Write("Number Should be Non Zero: ");
                goto Get_b;
            }

            Console.WriteLine("{0}\n{1}", "Enter an operation to perform on a and b:", "(add, minus, multiply, divide):");
        Choose_Operation:
            String ch = Console.ReadLine();
            switch (ch)
            {
                case "add":
                    Console.WriteLine("Total: {0} + {1} = {2}", a, b, a + b);
                    break;
                case "minus":
                    Console.WriteLine("Total: {0} - {1} = {2}", a, b, a - b); 
                    break;
                case "multiply":
                    Console.WriteLine("Total: {0} * {1} = {2}", a, b, a * b);
                    break;
                case "divide":
                    Console.WriteLine("Total: {0} / {1} = {2}", a, b, Convert.ToDouble(a) / b);
                    break;
                default:
                    goto Choose_Operation;
            }

            /////////////////////////////////Swapping///////////////////////////////////////////
            //a ^= b;
            //b = a ^ b;
            //a ^= b;
            //Console.WriteLine("a: {0} \nb: {1}", a, b);


            ///////////////////////////////////Exercise/////////////////////////////////////////
            //for (int i = 0; i < 5; i++)
            //{
            //    int str = 65;
            //    for (int j = 1; j < 2 * i; j++)
            //    {
            //        if (j < i)
            //        {
            //            Console.Write(Convert.ToChar(str));
            //            str++;
            //        }
            //        else
            //        {
            //            Console.Write(Convert.ToChar(str));
            //            str--;
            //        }

            //    }
            //    Console.Write("\n");
            //}

            //////////////////////////////////////Methods of String Formatting///////////////////////////
            string Name = "Sahil";
            string LastName = "XYZ";
            string concatiantion = string.Format("First Name {0} and Last Name is {1}", Name, LastName);
            
            string FullName = string.Concat(Name, ' ', b);
            Console.WriteLine(FullName);

            StringBuilder sb = new StringBuilder("xyz", 50);
            sb.Append(' ', a);
            sb.Append(LastName);
            sb.Replace("xyz", "ABC");
            sb.Remove(1, 1);
            Console.WriteLine(sb.ToString());
            string concate = $@"First Name {Name} and 
Last Name is {LastName}";

            Console.WriteLine(concatiantion);

            Console.WriteLine(concate);

            Console.ReadLine();
        }
    }
}
