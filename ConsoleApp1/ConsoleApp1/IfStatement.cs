using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            // Accept the temperature from the user. 
            Console.Write("Please enter the temperature today: ");
            string userinput = Console.ReadLine();
            int temp = Convert.ToInt32(userinput);

            Weather rec = new Weather();
            rec.answer = temp;
            string answer1 = rec.WTemp();

            

            Console.WriteLine(answer1);
          
        }
        class Weather
        {
            public int answer;
            // If the temperature is greater than or equal to 32, 
            // display a message “The climate is good today” 
            public string WTemp()
            {
                if (answer >= 32)
                {
                    return "The climate is good today";

                    if (answer = 32)
                    // check whether the temperature is exactly equal to 32. 
                    // If it is exactly equal to 32, display a message “The temperature is 32”. 
                    {
                        return "The temperature is 32";

                    }

                    //If the temperature is greater than 32, then display a message “It is hot today” 
                    else return "It is hot today";
                }
            }
        }  
            }
    }
}
