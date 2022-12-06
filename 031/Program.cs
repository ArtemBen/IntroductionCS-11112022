// 31.Сгенерировать 10 случайных чисел. Показать кубы тех чисел, которые заканчиваются на четную цифру
/*
int r=10;
double t=r;//неявное приведение типов
double x=23;
//int o=Convert.ToInt32(x);
int o=(int)x;//явное приведение типов
*/

Random random=new Random(10);
random.Next(1,100);
for(int i=0;i<5;i++)
{
    int a=random.Next(1,100);
    int b=(int)Math.Pow(a,3);
    if (b%10%2==0)
    System.Console.WriteLine($"{a}, {b}");
}
    
