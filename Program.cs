using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_P1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            //String to Decimal Using Parse
            try 
            {
                string myString = "John";

                decimal myDecimal;

                myDecimal = decimal.Parse(myString);

                Console.WriteLine(myDecimal.ToString()); 
            
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            */

            //String to an Integer using TryParse
            /*
            string strNumber1 = "123";
            int number;

            try
            {
               
                int.TryParse(strNumber1, out number);
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Error!!!" + e.Message);
            }
            */
            

            //String to decimal using Convert

            string strNumber2 = "123.45";
            double doubleNumber;

            doubleNumber = Convert.ToDouble(strNumber2);

            Console.WriteLine("The string '" + strNumber2 + "' can be converted to a double with value " + doubleNumber);

            Console.ReadKey();
            






        }
    }
}
