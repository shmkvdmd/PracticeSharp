using static System.Console;
//Complete the solution so that it splits the string into pairs of two characters.
//If the string contains an odd number of characters then 
//it should replace the missing second character of the final pair with an underscore ('_').
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
