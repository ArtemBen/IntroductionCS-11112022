﻿//Обмен значениями двух переменных
// Класический способ
/*int a=5;
int b=7;
int temp;
temp=a;
a=b;
b=temp;
*/
//Без использования 3 переменной
/*int a=5;
int b=7;
a=a+b;
b=a-b;
a=a-b;
*/
//
int a=5;
int b=7;
a=a^b;
b=a^b;
a=a^b;
System.Console.writeline($"a={a} b={b}");


