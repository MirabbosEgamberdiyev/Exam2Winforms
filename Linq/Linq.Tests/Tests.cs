using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Linq.Tests;

[TestFixture]
public class Tests
{
    [Test]
    public void Task1Test()
    {
        foreach (var (numbers, expected) in Task1Data())
        {
            var actualResult = Tasks.Task1(numbers);
            AssertIsLinq(actualResult);
            AssertIsAsExpected(expected.OrderBy(x => x), actualResult);
        }
    }

    [Test]
    public void Task2Test()
    {
        foreach (var (numbers, expected) in Task1Data())
        {
            var actualResult = Tasks.Task2(numbers);
            AssertIsLinq(actualResult);
            AssertIsAsExpected(expected.OrderByDescending(x => x), actualResult);
        }
    }

    [Test]
    public void Task3Test()
    {
        foreach (var (numbers, expected) in Task3Data())
        {
            var actualResult = Tasks.Task3(numbers);
            AssertIsLinq(actualResult);
            AssertIsAsExpected(expected, actualResult);
        }
    }

    [Test]
    public void Task4Test()
    {
        foreach (var (numbers, expected) in Task4Data())
        {
            var actualResult = Tasks.Task4(numbers);
            AssertIsLinq(actualResult);
            AssertIsAsExpected(expected.OrderByDescending(x => x), actualResult);
        }
    }

    [Test]
    public void Task5Test()
    {
        foreach (var (stringList, expected) in Task5Data())
        {
            var actualResult = Tasks.Task5(stringList);
            AssertIsLinq(actualResult);
            AssertIsAsExpected(expected.OrderBy(x => x), actualResult);
        }
    }

    [Test]
    public void Task6Test()
    {
        foreach (var (c, stringList, expected) in Task6Data())
        {
            var actualResult = Tasks.Task6(c, stringList);
            AssertIsLinq(actualResult);
            AssertIsAsExpected(expected.OrderBy(x => x), actualResult.OrderBy(x => x));
        }
    }

    [Test]
    public void Task7Test()
    {
        foreach (var (integerList, expected) in Task7Data())
        {
            var actualResult = Tasks.Task7(integerList);
            AssertIsLinq(actualResult);
            AssertIsAsExpected(expected, actualResult);
        }
    }

    [Test]
    public void Task8Test()
    {
        foreach (var (stringList, expected) in Task8Data())
        {
            var actualResult = Tasks.Task8(stringList);
            AssertIsLinq(actualResult);
            AssertIsAsExpected(expected, actualResult);
        }
    }

    [Test]
    public void Task9Test()
    {
        foreach (var (stringList, expected) in Task9Data())
        {
            var actualResult = Tasks.Task9(stringList);
            AssertIsLinq(actualResult);
            AssertIsAsExpected(expected.OrderBy(x => x), actualResult.OrderBy(x => x));
        }
    }

    [Test]
    public void Task10Test()
    {
        foreach (var (k, stringList, expected) in Task10Data())
        {
            var actualResult = Tasks.Task10(k, stringList);
            AssertIsLinq(actualResult);
            AssertIsAsExpected(expected, actualResult);
        }
    }

    [Test]
    public void Task11Test()
    {
        List<int> numbers = new List<int> { 1, 3, 2, 4, 5 };
        int result = Tasks.Task11(numbers);
        Assert.AreEqual(4, result);
    }

    [Test]
    public void Task12Test()
    {
        List<int> numbers = new List<int> { 1, 3, 2, 4, 5 };
        int n = 3;
        var result = Tasks.Task12(numbers, n);
        CollectionAssert.AreEqual(new List<int> { 5, 4, 3 }, result);
    }

    [Test]
    public void Task13Test()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int divisor1 = 2;
        int divisor2 = 7;
        bool result1 = Tasks.Task13(numbers, divisor1);
        bool result2 = Tasks.Task13(numbers, divisor2);
        Assert.IsTrue(result1);
        Assert.IsFalse(result2);
    }

    [Test]
    public void Task14Test()
    {
        List<string> list1 = new List<string> { "a", "b", "c" };
        List<string> list2 = new List<string> { "d", "e", "f" };
        var result = Tasks.Task14(list1, list2);
        CollectionAssert.AreEquivalent(new List<string> { "a", "b", "c", "d", "e", "f" }, result);
    }

    [Test]
    public void Task15Test()
    {
        List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3 };
        var result = Tasks.Task15(numbers);
        Assert.AreEqual(1, result[1]);
        Assert.AreEqual(2, result[2]);
        Assert.AreEqual(3, result[3]);
    }


    private IEnumerable<(IEnumerable<int> numbers, IEnumerable<int> expected)> Task1Data()
    {
        yield return (
            numbers: new[] { 23 },
            expected: new[] { 23 });
        yield return (
            numbers: new[] { 1, 1 },
            expected: new[] { 1, 1 });
        yield return (
            numbers: new[] { 233, 5667, 88987, 67, 34, 87 },
            expected: new[] { 34, 67, 87, 233, 5667, 88987 });
        yield return (
            numbers: new[] { 23, 5667, 88987, 67, 4, 87 },
            expected: new[] { 4, 23, 67, 87, 5667, 88987 });
    }

    private IEnumerable<(IEnumerable<int> numbers, IEnumerable<int> expected)> Task3Data()
    {
        yield return (
            numbers: new[] { 23 },
            expected: Array.Empty<int>());
        yield return (
            numbers: new[] { 12, 12 },
            expected: new[] { 12, 12 });
        yield return (
            numbers: new[] { 233, 5667, 88982, 67, 34, 87 },
            expected: new[] { 88982, 34 });
        yield return (
            numbers: new[] { 234, 56674, 88987, 67, 44, 876 },
            expected: new[] { 234, 56674, 44, 876}); 
    }

    private IEnumerable<(IEnumerable<int> numbers, IEnumerable<int> expected)> Task4Data()
    {
        yield return (
            numbers: new[] { 23 },
            expected: Array.Empty<int>());
        yield return (
            numbers: new[] { 12, 12 },
            expected: Array.Empty<int>());
        yield return (
            numbers: new[] { 232, 5667, 88982, 67, 34, 87, 2 },
            expected: new[] { 88982, 232});
        yield return (
            numbers: new[] { 234, 56674, 88987, 67, 44, 876 },
            expected: new[] { 56674, 876, 234});
    }

    private IEnumerable<(IEnumerable<string> stringList, IEnumerable<string> expected)> Task5Data()
    {
        yield return (
            stringList: new[] { "Abdulaxadova" },
            expected: Array.Empty<string>());
        yield return (
            stringList: new[] { "Abdulaxadov" },
            expected: new[] { "Abdulaxadov" });
        yield return (
            stringList: new[] { "Hamdamov", "Abdulaxadov", "Sergeyev", "Lazizova"},
            expected: new[] { "Abdulaxadov", "Hamdamov", "Sergeyev" });
    }

    private IEnumerable<(char c, IEnumerable<string> stringList, IEnumerable<string> expected)> Task6Data()
    {
        yield return (
            c: 'a',
            stringList: new[] { "a fkgfjkgfgmk a", "a", "adddddd", "ddddddda" },
            expected: new[] { "a fkgfjkgfgmk a" });
        yield return (
            c: 'g',
            stringList: new[] { "gf", "g", "gdddddd", "dddddddg" },
            expected: new List<string>());
        yield return (
            c: 'B',
            stringList: new[] { "BETA", "BETA B", "Be or not to be", "some sentence with B" },
            expected: new[] { "BETA B" });
        yield return (
            c: '+',
            stringList: new[] { "c++", "+-+", "+6987/", "+478+" },
            expected: new[] { "+-+", "+478+" });
    }

    private IEnumerable<(IEnumerable<int> integerList, IEnumerable<string> expected)> Task7Data()
    {
        yield return (
            integerList: new[] { 140, 45, 14, 0, 15, 147 },
            expected: new[] { "15", "45", "147" });
        yield return (
            integerList: new[] { 190, 56, 47, 5681, 45, 89652, 7893 },
            expected: new[] { "45", "47", "5681", "7893" });
        yield return (
            integerList: new[] { 93, 45, 789, 456, 45, 78, 235, 896, 4563 },
            expected: new[] { "45", "45", "93", "235", "789", "4563" });
        yield return (
            integerList: new[] { 92, 42, 782, 456, 44, 78, 236, 896, 4562 },
            expected: new List<string>());
    }

    private IEnumerable<(IEnumerable<string> stringList, IEnumerable<int> expected)> Task8Data()
    {
        yield return (
            stringList: new[] { "ddddddaaa", "dsjhdfoiwhveuvn", "hvbrurhvuirevhreuivguvvhu" },
            expected: new[] { 9, 15, 25 });
        yield return (
            stringList: new[] { "dddddd", "ddddd", "ddd", "dd", "d" },
            expected: new[] { 1, 2, 3, 5, 6 });
        yield return (
            stringList: new[]
            {
                    "turn", "cap", "the string dudududu", "some sentence with B",
                    "fertility", "the sharp", "some string", ""
            },
            expected: new[]
            {
                    0, 3, 4, 9, 9, 11, 19, 20
            });
    }

    private IEnumerable<(IEnumerable<string> stringList, IEnumerable<string> expected)> Task9Data()
    {
        yield return (
            stringList: new[] { "ehgrtthrehrehrehre", "fjjgoerugrjgrehg", "jgnjirgbrnigeheruwqqeughweirjewew" },
            expected: new[] { "ee", "fg", "jw" });
        yield return (
            stringList: new[] { "756998/*+fgh", "urhrhgu48GH", "SssssS", "the something;", "hello" },
            expected: new[] { "7h", "uH", "SS", "t;", "ho" });
        yield return (
            stringList: new[]
            {
                    "&ghjjpgirbigjrg5985849*///grgerge", "#fkgjklgflgk@", "irejgkerogruoj^", "some sentence with B",
                    "fertility", "the sharp", "some string", "a"
            },
            expected: new[]
            {
                    "&e", "#@", "i^", "sB",
                    "fy", "tp", "sg", "aa"
            });
    }

    private IEnumerable<(int k, IEnumerable<string> stringList, IEnumerable<string> expected)> Task10Data()
    {
        yield return (
            k: 1,
            stringList: new[] { "1", "f3", "8" },
            expected: new[] { "1", "8" });
        yield return (
            k: 4,
            stringList: new[] { "345e", "ABC1", "1437", "FGE3", "fire1" },
            expected: new[] { "1437", "ABC1", "FGE3" });
        yield return (
            k: 0,
            stringList: new[]
            {
                    "1", "5", "bc", "ABC1",
                    "fertility", "the sharp", "some string", "a"
            },
            expected: new List<string>());
        yield return (
            k: 12,
            stringList: new[]
            {
                    "the big cup2", "#fkgjklgflgk2", "The objection", "###########1",
                    "fertility", "the big cup1", "some string", "a"
            },
            expected: new[]
            {
                    "###########1", "the big cup1", "the big cup2"
            });
    }

    #region Utility

    private void AssertIsLinq<T>(IEnumerable<T> result)
    {
        Assert.AreEqual("System.Linq", result.GetType().Namespace, "Result is not linq");
    }

    private void AssertIsAsExpected<T>(IEnumerable<T> expected, IEnumerable<T> actual)
    {
        Assert.AreEqual(expected, actual);
    }

    private void AssertIsAsExpected<T>(IEnumerable<T> expected, IEnumerable<T> actual, IEqualityComparer<T> comparer)
    {
        Assert.True(expected.SequenceEqual(actual, comparer), "Result is not as expected");
    }

    #endregion
}