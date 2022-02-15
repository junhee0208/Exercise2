using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            Console.WriteLine("Input from user: ");
            int[] answer = new int[12];
            string numbers = "";
            for (int i = 0; i < answer.Length; i++)
            {
                try
                {
                    answer[i] = int.Parse(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("Something went wrong! ");
                }
                
            }

            for (int i = 0; i < answer.Length; i++)
            {
                //Console.Write(answer[i]);
                numbers = string.Join("", answer);
            }

            for (int i = 0; i < answer.Length+1; i++)
            {
                if (isValid(answer[i], answer[i + 1]))
                {
                    if (i % 3 == 2)
                    {
                        if (!isValid(answer[i], answer[i + 1]))
                        {
                            Console.WriteLine(numbers + "is Invalid answer");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(numbers + "is Invalid answer");
                    break;
                }
                
            }
            
            

            Console.ReadKey(true);

        }

        public static bool isValid(int pre, int current)
        {
            if (pre > current)
                return false;
            else if (pre + 1 < current)
                return false;

            return true;
        }
    }
}
