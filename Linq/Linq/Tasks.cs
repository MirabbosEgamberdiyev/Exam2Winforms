using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq;

public static class Tasks
{
    //return uchun bitta qatorda linq so'rovini yozing. Misol uchun
    public static string TaskExample(IEnumerable<string> stringList)
    {
        throw new NotImplementedException();
    }

    #region Tasks

    public static IEnumerable<int> Task1(IEnumerable<int> numbers)
    {
        return numbers.OrderBy(num => num);
    }

    public static IEnumerable<int> Task2(IEnumerable<int> numbers)
    {
        return numbers.OrderByDescending(num => num);

    }

    public static IEnumerable<int> Task3(IEnumerable<int> numbers)
    {
        return from num in numbers
               where num%2==0
               select num;
    }

    public static IEnumerable<int> Task4(IEnumerable<int> numbers)
    {
        return numbers.Where(num => num > 100 && num % 2 == 0).OrderByDescending(num => num);
    }


    public static IEnumerable<string> Task5(IEnumerable<string> stringList)
    {
        return stringList.Where(str => !str.EndsWith("a")).OrderBy(str => str);
    }

    public static IEnumerable<string> Task6(char c, IEnumerable<string> stringList)
    {
        return stringList.Where(str =>str.StartsWith(c) && str.EndsWith(c) && str.Length>1).OrderBy(str => str);
    }

    public static IEnumerable<string> Task7(IEnumerable<int> integerList)
    {
        return integerList.Where(num => num % 2 != 0).OrderBy(num => num).Select(num => num.ToString());
    }

    public static IEnumerable<int> Task8(IEnumerable<string> stringList)
    {
        return stringList.Select(num => num.Length).OrderBy(num => num);
    }

    public static IEnumerable<string> Task9(IEnumerable<string> stringList)
    {
        return stringList.Select(str => str[0].ToString() + str[^1]);

    }

    public static IEnumerable<string> Task10(int k, IEnumerable<string> stringList)
     => stringList.Where(x => x.Length == k && char.IsDigit(x[x.Length - 1])).OrderBy(x => x);


    // Task 11: Find the second highest number in a list.
    public static int Task11(List<int> numbers)
    {
        return numbers.OrderBy(num => num).ToList()[^2];
    }

    // Task 12: Get the top N elements from a list.

    public static IEnumerable<int> Task12(List<int> numbers, int n)
        => numbers.OrderByDescending(x => x).Take(n);

    // Task 13: Check if any element in the list is divisible by a given divisor.
    public static bool Task13(List<int> numbers, int divisor)
    {
        return numbers.Any(num => num % divisor == 0);
    }

    // Task 14: Join two lists of strings into a single list.
    public static List<string> Task14(List<string> list1, List<string> list2)
    {
        return list1.Concat(list2).ToList();
    }


    // Task 15: Get the number of occurrences of each element in a list.
    public static Dictionary<int, int> Task15(List<int> numbers)
    {
        return numbers.GroupBy(num => num)
                      .ToDictionary(group => group.Key, group => group.Count());
    }

    #endregion
}
