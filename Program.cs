using System;

namespace Generic_Practice_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC1 Check the Maximum Integer Number
            Console.WriteLine("Maximum Integer Number is: ");
            int output = UC1MaxInt.MaximumIntegerNumber(65, 21, 15);
            Console.WriteLine(output);

            //////UC2 Check the Maximum Float Number
            //Console.WriteLine("Maximum Float Number is:");
            //double doubleoutput = UC2MaxFloat.MaximumFloatNumber(56.3, 87.12, 150.2);
            //Console.WriteLine(doubleoutput);

            //////UC3 Check the Maximum string Number
            //Console.WriteLine("Maximum String value is : ");
            //string strigoutput = UC3MaxString.MaximumStringNumber("Apple", "Peach", "Banana");
            //Console.WriteLine(strigoutput);


            //Refactor 1
            //Console.WriteLine("Maximum Integer Value:=" + MaxOf3Values.findmax<int>(11, 100, 285));
            //Console.WriteLine("Maximum Float Value:=" + MaxOf3Values.findmax<float>(5.19f, 4.9f, 3.22f));
            //Console.WriteLine("Maximum String Value:=" + MaxOf3Values.findmax<string>("Akash", "Vaibhav", "Vishal"));

            //Refactor 2
            //Console.WriteLine("Maximum Integer Is:" + MaxOfValues<int>.findmax(2, 8, 10));
            //Console.WriteLine("Maximum Float Is:" + MaxOfValues<float>.findmax(9.32f, 7.77f, 9.99f));
            //Console.WriteLine("Maximum String Is:" + MaxOfValues<string>.findmax("yzy", "xpx", "wxy"));




        }
    }
}
