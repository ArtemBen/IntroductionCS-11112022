// 

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr2 = new string[5];
            Array myArr = Array.CreateInstance(typeof(string),5);
            myArr.SetValue("Первое",0);
            myArr.SetValue("Второе",1);
            myArr.SetValue("Третье",2);
            string[] arr1 = (string[])myArr.Clone();

            foreach (string s in arr1)
                Console.Write("\t"+s);

            Console.WriteLine();
            Array.Copy(myArr, arr2, myArr.Length);
            foreach (string s in arr2)
                Console.Write("\t"+s);

            Console.ReadLine();
        }
    }
}