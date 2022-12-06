// 24. Вывести на экран таблицу квадратов чисел от 1 до N


class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кол-во чисел:");
            int N=int.Parse(Console.ReadLine());//не понимаю, что за ошибка, но программа работает. Может синтаксическая
             Console.WriteLine("Введите число" + "\t" + "Ввести квадрат");
            for(int i = 1; i <= N; i++)
                Console.WriteLine(i + "\t" + i*i);
 
            Console.ReadLine();
  
        }
    }
