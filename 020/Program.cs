﻿// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

//тип имя(аргументы подпрограммы)

int Part(double x,double y)
{
//тело подпрограммы
    
    if (x>0 && y>0) return 1;
    if (x<0 && y>0) return 2;
    if (x<0 && y<0) return 3;
    if (x>0 && y<0) return 4;
    return 0;    
}

void Pause()
{
    System.Console.WriteLine("Press any key");
    Console.ReadKey();
}

double x=Convert.ToDouble(Console.ReadLine());
double y=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Part:"+Part(x,y));;


//System.Console.WriteLine("Part:"+part);