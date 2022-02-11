// Programmer: Fahim Farhan Khan
// Project: T-3
// Date: 02/10/2022
// Description: Currency Converter from CAD to USD
using System;

namespace Currnecy_Coverter
{
	class CurrencyConverter
	{
		static void Main(string[] args)
		{
            // Ask the user for input
            Console.Write("Enter CAD$ value to convert to USD$ ($5-$25)");
            
            try
            {
                // Variables to gather data for the input
                string userinput = Console.ReadLine();

                int value = int.Parse(userinput);
                // Variable for conversion
                double c = 0.792367;
            
                // Showing error for invalid input
                if (value < 5 | value > 25)
                {
                    Console.WriteLine("Please enter a value between CAD$ 5-25 ");
                    Console.WriteLine("Please enter any key to exit");                    
                }
               
                // Showing correct output for valid inputs
                else if ((value >= 5) && (value <= 25))
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("CAD" + "\t" + "\t" + "USD");
                    Console.WriteLine(" ");
                    for (int i = 0; i < 201; i += value)
                    {
                        
                        
                        Console.WriteLine(i + "\t" + "\t" + String.Format("{0:C}", i * c));
                    }
                }
            }// End of try
            catch
            {
                Console.WriteLine("Please enter a valid amount and try again");
                Console.WriteLine("Please enter any key to exit...");
                Console.ReadKey(true);

            }// End of catch
			}
		
		}
	}

