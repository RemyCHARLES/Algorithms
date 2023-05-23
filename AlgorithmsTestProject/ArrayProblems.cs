namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
        throw new NotImplementedException();
    }

    public static void Swap<T>(T[] xs, int a, int b)
    {
        if (xs.Length < 2)
        {
            throw new Exception("Array must have at least 2 elements");
        }
        else if (a < 0 || a >= xs.Length)
        {
            throw new Exception("Index out of range");
        }
        else if (b < 0 || b >= xs.Length)
        {
            throw new Exception("Index out of range");
        }
        else
        {
            var tmp = xs[a];
            xs[a] = xs[b];
            xs[b] = tmp;
        }     
    }

    public static T FirstElement<T>(T[] xs)
    {
        throw new NotImplementedException();
    }

    public static T LastElement<T>(T[] xs)
    {
        throw new NotImplementedException();
    }

    public static T MiddleElement<T>(T[] xs)
    {
        throw new NotImplementedException();
    }

    public static void Reverse<T>(T[] xs)
    {
       Array.Reverse(xs); 
    }

    public static int CountElement<T>(T[] xs, T element)
    { 
        throw new NotImplementedException();
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        throw new NotImplementedException();
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        throw new NotImplementedException();
    }
}