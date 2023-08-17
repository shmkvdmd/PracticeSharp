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