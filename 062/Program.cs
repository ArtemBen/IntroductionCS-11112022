// 62.В двумерном массиве n×k заменить четные элементы на противоположные по значению 
//(a[i,j]=-a[i,j]). Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.

int[,] Create2DArray(int n,int m)
{
    int[,] a=new int[n,m];
    for(int i=0;i<n;i++)
        for (int j=0;j<m;j++)
                a[i,j]=i+j;
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
            System.Console.WriteLine();
        }
}