using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string triType;

            while (true){
                Console.Write("-------------------\n");
                Console.Write("\tMenu\n");
                Console.Write("-------------------\n\n");

                Console.Write("1. Enter triangle dimensions\n");
                Console.Write("2. Exit\n\n");

                Console.Write("Your option : ");


                int opt = Int32.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.Write("\nEnter 1st dimension: ");
                        num1 = Int32.Parse(Console.ReadLine());

                        Console.Write("Enter 2nd dimension: ");
                        num2 = Int32.Parse(Console.ReadLine());
                         
                        Console.Write("Enter 3rd dimension: ");
                        num3 = Int32.Parse(Console.ReadLine());

                        triType = TriangleSolver.Analyze(num1, num2, num3);

                        Console.Write("\nTriangle is "+triType+"\n\n\n");
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("\nInvalid option! Try Again.\n\n\n");
                        break;
                }
            }
        }
    }
}
