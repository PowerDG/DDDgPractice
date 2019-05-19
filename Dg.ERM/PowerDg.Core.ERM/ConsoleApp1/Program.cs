using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            char c;

            int n;
            do
            {
                ConsoleKeyInfo keyinfo = Console.ReadKey(true);

                //string a = Console.ReadLine().ToString();
                //  c = a[0];
                //Console.WriteLine(Tran(c));

                if (int.TryParse(keyinfo.KeyChar.ToString(), out n))
                {
                    //Console.WriteLine("你选择了:" + (n - 64));
                    Console.WriteLine("你选择了:" + (n));
                }
                else
                {
                    Console.WriteLine("请按数字键选择");
                }


            } while (n != 0);

            Console.ReadKey();
        }


        public static int Tran(char cha)
        {

            int b = Convert.ToInt32(cha);
            if (Convert.ToInt32(cha) > 64 && Convert.ToInt32(cha) < 91)
            {
                return b - 64;
            }
            else
            {
                return 0;
            }
        }

        public static void Tranf(char cha)
        {

            while (true)
            {
                String letter = Console.ReadLine();
                char[] ascs = letter.ToCharArray();
                foreach (char asc in ascs)
                {
                    int ascNum = (int)asc;

                    if (ascNum >= 65 && ascNum <= 90)
                    {
                        Console.WriteLine(ascNum - 64);
                    }
                    if (ascNum >= 97 && ascNum <= 122)
                    {
                        Console.WriteLine(ascNum - 96);
                    }
                }
            }

        }
    }
}
