using System;

namespace Tech_Project_3
{
    class Program
    {
        static void Main(string[] args)
        {

            // establish int as miles and kilometers
            int miles, kilometer;

            // Ask the user for input to conversion
            Console.WriteLine("Please enter an integer between 10 and 25 to execute an iterative statement to find the conversion to miles to kilometers:");
            miles = Convert.ToInt32(Console.ReadLine());
            
            // set integer miles between 10 and 25
            if (miles is >= 10 and <= 25)

                // set kilometer max is 200 and increase by 10
                for (kilometer = 0; kilometer <= 200; kilometer+=10)
            {
                Console.WriteLine("{0} miles is equal to {2} kilometers", kilometer, miles, (miles * 0.621371));
            }

            // close the program
            Console.WriteLine("Press any key to close the program!");
            Console.ReadKey(true);


            }

        }
}  


