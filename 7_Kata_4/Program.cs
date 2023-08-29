//Given an array of integers, remove the smallest value. 
//Do not mutate the original array/list. 
//If there are multiple elements with the same value, remove the one with a lower index. 
//If you get an empty array/list, return an empty array/list.
//Don't change the order of the elements

using static System.Console;

List<int> ints = new List<int> { 2, 2, 1, 2, 1 };

foreach (int i in RemoveSmallest(ints))
{
    WriteLine(i);
}
List<int> RemoveSmallest(List<int> numbers)
{
    numbers.Remove(numbers.DefaultIfEmpty().Min());
    return numbers; 
}