// Ввод-вывод двумерного массива, поиск в двумерном массиве, сортировка двумерного массива
//(по колонкам, так как в дз есть задание на сортировку по строкам)

int[,] a=new int[3,4];
//int[,] a1=new int[3,4] {{1,2,3,4},{1,2,3,4},{1,2,3,4}};
//int[,] a2= {{1,2,3,4},{1,2,3,4},{1,2,3,4}};
Random random=new Random();
for(int i=0;i<3;i++)
    for (int j=0;j<4;j++)
        a[i,j]=random.Next(0,10);

for(int i=0;i<3;i++)
{
    for (int j=0;j<4;j++)
        System.Console.Write($"{a[i,j],4}");
    System.Console.WriteLine();
}
    