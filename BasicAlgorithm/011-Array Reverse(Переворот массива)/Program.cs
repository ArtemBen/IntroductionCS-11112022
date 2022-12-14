// 

int[] RandomIntArray(int N,int min,int max)
{
    int[] a=new int[N];
    Random random=new Random();
    for(int i=0;i<a.Length;i++)
        a[i]=random.Next(0,200);
    return a;
}

void PrintArray(int[] a,int tab=5)
{
    string formatString="{0,"+tab+"}";
    for(int i=0;i<a.Length;i++)
        System.Console.Write(formatString,a[i]);
}



void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void Reverse(int[] a)
{
   for(int i=0;i<a.Length/2;i++)
        Swap(ref a[i],ref a[a.Length-1-i]);
}
int M=10;
int[] a=RandomIntArray(M,0,200);
PrintArray(a,5);
Reverse(a);
System.Console.WriteLine();
PrintArray(a,5);