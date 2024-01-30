using System;
using System.Buffers;
using System.Reflection.Metadata.Ecma335;

namespace App1
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Input 1 to 10");
            string NumInput = Console.ReadLine();


            int.TryParse(NumInput, out int result);
            if (result >= 1 && result <= 10)
            {
                Console.WriteLine("вы ввели " + result);
            }
            else
            {
                Console.WriteLine("читай условие внимательно ");
            }







        }
           

        }



    }
    
