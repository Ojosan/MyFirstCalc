using System;

namespace calc1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //printing welcome
            Console.Write("Please enter your name: ");
            string user = Console.ReadLine();
            Console.WriteLine("welcome " + user + "!");
  
            //separator, for more organization
            Console.WriteLine("-----------------------------------------\n");
       
            
            //inputs numbers
            Console.Write("please enter a number: ");
            var num1 = Console.ReadLine();
            Console.Write("please enter a number: ");
            var num2 = Console.ReadLine();

            //results

            double sum = Convert.ToDouble(num1) + Convert.ToDouble(num2);

            double diff = Convert.ToDouble(num1) - Convert.ToDouble(num2);
            
            double pro = Convert.ToDouble(num1) * Convert.ToDouble(num2);

            double quo = Convert.ToDouble(num1) / Convert.ToDouble(num2);

            //print results

            Console.WriteLine();
            Console.WriteLine("Results:");
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine("difference: " + diff);
            Console.WriteLine("product: " + pro);
            Console.WriteLine("quotient: " + quo);

            //exit program

            Console.WriteLine("thank you for using calc. press any key to exit.");
            Console.ReadLine();


        }
    }
}
