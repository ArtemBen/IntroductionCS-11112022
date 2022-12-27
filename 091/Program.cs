// 91


bool Test(string s1,string s2)
{
    if (s1.Length!=s2.Length) return false;
    char[] c1=s1.ToCharArray();
    char[] c2=s2.ToCharArray();
    Array.Sort(c1);
    Array.Sort(c2);
    s1=new String(c1);
    s2=new String(c2);
    return s1==s2;
}

string s1="ABCDE";
string s2="ACDBE";

System.Console.WriteLine(Test(s1,s2));