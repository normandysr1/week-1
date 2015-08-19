using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static void Main(string[] args)
        {
            inputFunc();
        }

        static public void inputFunc()
        {
            string Sinput;

            Console.WriteLine("Input the integers: ");
            Sinput = Console.ReadLine();
            processFunc(Sinput);
        }

        static public void processFunc(string Sinput)
        {
            int[] input;
            input = Sinput.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();


            bool flag = true;

            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }

            outputFunc(input);
        }

        static public void outputFunc(int[] input)
        {
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }

    }
}
