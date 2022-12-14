// 52. Написать программу преобразования десятичного числа в двоичное


int n=2;
string s="";
while(n!=0)
{
    System.Console.Write(n%2);
    s=Convert.ToString(n%2)+s;
    n/=2;
}
System.Console.WriteLine();
System.Console.WriteLine(s);