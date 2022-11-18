// //*2.С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго (блок-схема)

/*
//полное условие
if ()
{
    //true
}
else
{
    //false
}
//неполное условие
if()
{
    //true
}
*/

double a=Convert.ToDouble(Console.ReadLine());
double b=Convert.ToDouble(Console.ReadLine());

if (a*a==b) System.Console.WriteLine($"{b} является квадратом {a}");
if (b*b==b) System.Console.WriteLine($"{a} является квадратом {b}");