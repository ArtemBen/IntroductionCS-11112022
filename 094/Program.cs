﻿// 94.*Составить частотный словарь элементов одномерного массива состоящих из чисел от 0 до 99.


int[] data={1,3,4,8,3,5,8};
int[] freqArr=new int[100];
foreach(int element in data)
    freqArr[element]++;
for(int i=0;i<freqArr.Length;i++)
    if (freqArr[i]!=0)
        System.Console.WriteLine($"{i} {freqArr[i]}");