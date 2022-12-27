// 83.Подсчитать количество цифр среди вводимых с клавиатуры символов

string s=Console.ReadLine();
int k=0;
for(int i=0;i<s.Length;i++)
    if (char.IsDigit(s[i])) k++;
System.Console.WriteLine(k);

