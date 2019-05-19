using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string a = Console.ReadLine().ToString();
            char c= a[0];
            Console.WriteLine(Tran(c));
            Console.ReadKey();
        }


        public static int Tran(char cha)
        {

            int b = Convert.ToInt32(cha);
            if (Convert.ToInt32(cha) > 64 && Convert.ToInt32(cha)  < 91)
            {
                return b - 64;
            }
            else
            {
                return 0;
            }
        }
    }
}
