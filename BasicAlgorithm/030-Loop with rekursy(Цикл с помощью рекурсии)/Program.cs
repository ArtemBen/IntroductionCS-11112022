﻿// Вывести числа от 1 до N без использования цикла

/*
int i=1;
int N=10;
metka:
    System.Console.WriteLine(i);
    i++;
if(i<N) gototo metka;
*/

void Loop(int N, int i)
{
    if (i<N)
    {
        System.Console.WriteLine(i);
        Loop(N,i+1);
    }
}


Loop(10,1);