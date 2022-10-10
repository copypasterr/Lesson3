using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check_x, check_y;
            Console.WriteLine("Input the range numbers:");


            do {

                Console.WriteLine("Input x: ");
                string data_x = Console.ReadLine();
                Console.WriteLine("Input y: ");
                string data_y = Console.ReadLine();
                check_x = int.TryParse(data_x, out int x);
                check_y = int.TryParse(data_y, out int y);
                if (check_x && check_y)
                {
                    Console.WriteLine($"Input succes: x={x} y={y}");
                    int sum = 0;

                    if (x < y)
                    {
                        for (int i = x; i <= y; i++)
                        {
                            sum += x;
                            x++;
                        }
                    }

                    else if (x > y)
                    {
                        for (int i = y; i <= x; i++)
                        {
                            sum += y;
                            y++;
                        }
                    }

                    else sum = x;

                    Console.WriteLine($"Sum = {sum}");

                }

                else
                {
                    if (check_x == false && check_y ==true)
                        Console.WriteLine("X value incorrect. Try again...");

                    else if(check_y == false && check_x == true)
                        Console.WriteLine("Y value incorrect. Try again...");

                    else Console.WriteLine("X,Y value incorrect. Try again...");
                }

            } while (check_x == false|| check_y == false);
        }
    }
}
