/*
// See https://aka.ms/new-console-template for more information

System.Console.WriteLine();
Console.WriteLine("Hello, World!");
Console.WriteLine("2+2");
*/


/*int a=0,b=0,c=0;//целый
float f=20.4f;
double d=3.14;//вещественный
string s="asdasd";
char c0='a';
bool flag=true;
int переменная1=0;

int @_45f;
int @int=4;
*/
//1.С клавиатуры вводится целое число. Вывести квадрат числа

int a;
a=10;
System.Console.Write("Введите число:");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a*a;
System.Console.WriteLine(Convert.ToString(a)+"^2="+b.ToString());

