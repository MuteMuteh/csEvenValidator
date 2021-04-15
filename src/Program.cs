using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Even_Validator
{
    class Program
    {

        public static Boolean Menu()
        {
            bool is_true = true;
            Console.WriteLine("***** Option Menu *****");
            
            Console.WriteLine("Press 1 to enter the program");

            Console.WriteLine("Press 2 to clear text");

            Console.WriteLine("Press 0 to exit");

            String option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Validate();
                    break;
                case "2":
                    Console.Clear();
                    break;
                case "0":
                    is_true = false;
                    break;
                default:
                    Console.WriteLine("Select one of the available");
                    break;
            }

            return is_true;
        }


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Even validator by Carlos Muñoz at InacapSoft Copyright© 2019-2021\n");

            while (Menu());

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }

        public static Boolean isNumber(String n)
        {
            int validate = 0;
            try 
            {
                validate = int.Parse(n);
                return true;
            }
            catch
            {
                Console.WriteLine("You can only insert numbers");
                return false;
            }
       
            }

        public static Boolean isEvenChar(char[] chars)
        {
            int count = 0;
            int[] intarr = new int[chars.Length];

            for (int i = 0; i < chars.Length; i++)
            {
               // Console.WriteLine(chars[i]);
                intarr[i] = chars[i];
            }

            for (int j = 0; j < intarr.Length; j++)
            {
                if(intarr[j] % 2 != 0)
                {
                    count++;
                }

                if (count > 0)
                {
                    return false;
                }
            }

            
            return true;
        }

       public static void Validate()
        {

                Console.WriteLine("Insert a set on numbers");
                String input = Console.ReadLine().Trim();
                char[] charset = input.ToCharArray();

                if (isNumber(input))
                {
                    if (isEvenChar(charset))
                    {
                        Console.WriteLine("All numbers in the array are even");

                    }
                    else
                    {
                        Console.WriteLine("There were odd numbers found, try again");

                    }
                }


            
        }

    }
}
