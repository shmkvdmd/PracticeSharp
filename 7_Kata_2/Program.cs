/*The Western Suburbs Croquet Club has two categories of membership, Senior and Open. 
 They would like your help with an application form that will tell prospective members which category they will be placed.

To be a senior, a member must be at least 55 years old and have a handicap greater than 7. 
In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.

Input
Input will consist of a list of pairs. Each pair contains information for a single potential member. 
Information consists of an integer for the person's age and an integer for the person's handicap.

Output
Output will consist of a list of string values (in Haskell and C: Open or Senior) 
stating whether the respective member is to be placed in the senior or open category.

Example
input =  [[18, 20], [45, 2], [61, 12], [37, 6], [21, 21], [78, 9]]
output = ["Open", "Open", "Senior", "Open", "Open", "Senior"]
*/
IEnumerable<string> OpenOrSenior(int[][] data)
{
    List<string> result = new List<string>();
    for (int i = 0; i < data.Length; i++)
    {
        for (int j = 0; j < data[i].Length-1; j++)
        {
            if (data[i][j] >= 55 && data[i][j + 1] > 7)
            {
                result.Add("Senior");
            }
            else result.Add("Open");
        }
    }
    return result;
}

List<string> str = (List<string>)OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } });
for (int i = 0; i < str.Count; i++)
{
    Console.WriteLine(str[i]);
}