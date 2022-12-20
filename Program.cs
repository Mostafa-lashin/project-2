using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progect__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("project <2>");

            Console.Write("Enter the number to start counting from: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the number to stop counting to: ");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                    else
                        continue;
          
                }
                if(sum == i)
                {
                    Console.WriteLine(i);
                }
                
            }

        }
              
    }
}   
