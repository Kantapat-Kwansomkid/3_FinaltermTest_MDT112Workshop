using System;

namespace _3_FinaltermTest_MDT112Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int Input;
            int FindMax = 0;
            Console.Write("");
            Input = int.Parse(Console.ReadLine());

            string input1;
            input1 = Console.ReadLine();

            while (input1 != "End")
            {

                FindMax = Input + FindMax;
                Console.Write("");
                Input = int.Parse(Console.ReadLine());

            }
            Console.Write("{0}", FindMax);
            Console.ReadLine();

            int FindMin = 0;
            Console.Write("");

            string input2;
            input2 = Console.ReadLine();

            while (input2 != "End")
            {

                FindMin = Input + FindMin;
                Console.Write("");
                Input = int.Parse(Console.ReadLine());

            }
            Console.Write("{0}", FindMin);
            Console.ReadLine();

            int FindMean = 0;
            Console.Write("");

            string input3;
            input3 = Console.ReadLine();

            while (input3 != "End")
            {

                FindMean = Input + FindMean;
                Console.Write("");
                Input = int.Parse(Console.ReadLine());

            }
            Console.Write("{0}", FindMean);
            Console.ReadLine();

            int FindSD = 0;
            Console.Write("");

            string input4;
            input4 = Console.ReadLine();

            while (input4 != "End")
            {

                FindSD = Input + FindSD;
                Console.Write("");
                Input = int.Parse(Console.ReadLine());

            }
            Console.Write("{0}", FindSD);
            Console.ReadLine();
        }
    }
}
