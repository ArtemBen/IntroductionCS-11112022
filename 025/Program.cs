// 25.Вывести на экран кубы чисел от 1 до N


static void Main(string[] args)
        {
            int i;
            for (i = 20; i >= 5; i--)
                Console.Write(i * i * i + " ");
            Console.ReadLine();
                i = 20;
                while (i >= 5)
                {
                    Console.Write(i * i * i + " ");
                    i--;
                }
                Console.ReadLine(); 
            i = 20;
            do
            {
                Console.Write(i * i * i + " ");
                i--;
            }
            while (i >= 5);
            Console.ReadLine();
}