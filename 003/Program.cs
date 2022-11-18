// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.

int a, b;
 
Console.WriteLine();
 
a = Convert.ToInt32(Console.ReadLine());
 
b = Convert.ToInt32(Console.ReadLine());
 
if (a > b)
 
        {
 
            Console.WriteLine(a);
 
        }
 
        else
 
        {
 
            Console.WriteLine(b);
 
        }
 
        Console.ReadLine();