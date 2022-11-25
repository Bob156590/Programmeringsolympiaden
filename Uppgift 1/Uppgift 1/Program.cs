using System;

namespace tba
{
    class program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int tor = 0;
            int mor = 0;
            int morötter = 40;
            bool kk = true;
            try
            {
                Console.WriteLine("Tors tid ? ");
                int tort = int.Parse(Console.ReadLine());
                Console.WriteLine("Mors tid ? ");
                int mort = int.Parse(Console.ReadLine());
                for (i = 0; kk; i++)
                {
                    if (morötter == 1 && i % tort == 0 && i % mort == 0)
                    {
                        kk = false; 
                    }
                    else if (i % tort == 0 && morötter != 0)
                    {
                        morötter--;
                        tor++;
                    }
                    if (morötter == 1 && i % tort == 0 && i % mort == 0)
                    {
                        kk = false;
                    }
                    else if (i % mort == 0 && morötter != 0)
                    {
                        morötter--;
                        mor++;
                    }
                }
               
            }
            catch (FormatException)
            {
                Console.WriteLine("Pls write only numbers");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't duvude by zero dumbass.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }

            Console.WriteLine($"SVAR:Tor {tor},     Mor {mor}");
        }
    }
}