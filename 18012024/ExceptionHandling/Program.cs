using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2];
            try
            {
                string num1Str = Console.ReadLine();
                int num1 = Convert.ToInt32(num1Str);
                arr[0] = num1;
                

                string num2Str = Console.ReadLine();
                int num2 = Convert.ToInt32(num2Str);
                arr[1] = num2;

                Console.WriteLine(num1 / num2);
            }
            catch(FormatException ex) 
            {
                Console.WriteLine("Daxil etdiyiniz deyer eded formatinda deyil!");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("0-a bolme yoxdur!");
            }
            catch(Exception)
            {
                Console.WriteLine("Bilinmedik bir xeta bas verdi");
            }
            finally
            {
                Console.WriteLine("Hesablanma bitdi!");
            }

            Console.WriteLine("Davam edir");
           
        }
    }
}
