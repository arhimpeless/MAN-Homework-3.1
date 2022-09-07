namespace Задание_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method_1();
            //Method_2();
            //Method_3();
            int min = 1;
            int max = 2;
            Method_4 (min, max); 
        }
        public static void Method_4(int min, int max)
        {
            Console.Write("Введите целое значение диапазона от: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Введите целое значение диапазона до: ");
            max = int.Parse(Console.ReadLine());
            Random random = new Random();
            int myInt = 1;
            if (min > max)
            {
                double pi = Math.PI;
                Console.WriteLine(pi);
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.Write(random.Next(min, max));
                }
                while (myInt == min || myInt > max);
                Console.ReadKey();
            }
        }
        private static void Method_3()
        {
            int k;
            Console.Write("Введите целое положительное число: ");
            k = int.Parse(Console.ReadLine());
            if (k > 0)
            {
                for (int i = 0; i < k; i++)    //&& i %= 3 && i = 5
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.WriteLine("Операция завершена!");
        }
        private static void Method_2()
        {
            Console.WriteLine("Числа от 10 до 1:");
            int j = 11;
            while (j > 1)
            {
                j--;
                Console.WriteLine(j);
            }
        }
        private static void Method_1()
        {
            Console.WriteLine("Числа от 0 до 9:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}