using System.Security.Cryptography.X509Certificates;
using static System.Console;

string str = "abc";
if (str.Length % 2 != 0)
    str += "_";
int count = 0;
string[] arr = new string[str.Length / 2];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = str.Substring(count,2);
    count += 2;
}
foreach (var arrs in arr)
{
    WriteLine(arrs);
}
string[] Solution(string str)
{
    if (str.Length % 2 != 0)
        str += "_";
    string[] arr = new string[str.Length / 2];
    for (int i = 0; i < str.Length; i+=2)
    {
        str.Insert(i, " ");
    }
    return null;
}