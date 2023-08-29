//Check to see if a string has the same amount of 'x's and 'o's. 
//The method must return a boolean and be case insensitive. The string can contain any char.

using static System.Console;

WriteLine(XO("xxOo"));
bool XO(string input)
{
    int ocount = 0;
    int xcount = 0;
    foreach (char c in input)
    {
        if (char.ToLower(c) == 'x') xcount++;
        if (char.ToLower(c) == 'o') ocount++;
    }
    return xcount == ocount;
}