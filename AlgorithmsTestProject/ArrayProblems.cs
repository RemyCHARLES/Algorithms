namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
  
        if (xs.Length != ys.Length)
        {
            return false;
        }
        else
        {
            for (var i = 0; i < xs.Length; i++)
            {
                if (!xs[i].Equals(ys[i]))
                {
                    return false;
                }
            }

            return true;
         
        }
    }

    public static void Swap<T>(T[] xs, int a, int b)
    {
        var tmp = xs[a];
        xs[a] = xs[b];
        xs[b] = tmp;
    }

    public static T FirstElement<T>(T[] xs)
    {
        if (xs.Length < 0)
        {
            throw new Exception("Array must have at least 1 element");
        }
        else
        {
            return xs[0];
        }
    }

    public static T LastElement<T>(T[] xs)
    {
        if (xs.Length < 0)
        {
            throw new Exception("Array must have at least 1 element");
        }
        else
        {
            return xs[xs.Length - 1];
        }
    }

    public static T MiddleElement<T>(T[] xs)
    {
        if (xs.Length < 0)
        {
            throw new Exception("Array must have at least 1 element");
        }
        else
        {
            return xs[xs.Length / 2];
        }
    }

    public static void Reverse<T>(T[] xs)
    {
       Array.Reverse(xs); 
    }

    public static int CountElement<T>(T[] xs, T element)
    { 
        if (xs.Length == 0)
        {
            return 0;
        }
        else
        {
            var count = 0;
            foreach (var x in xs)
            {
                if (x.Equals(element))
                {
                    count++;
                }
            }

            return count;
        }
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        if (xs.Length == 0)
        {
            return "";
        }
        else
        {
            var result = "";
            foreach (var x in xs)
            {
                result += x + ",";
            }

            return result.Substring(0, result.Length - 1);
        }
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        if (xs.Length == 0)
        {
            return 0;
        }
        else
        {
            var count = 0;
            foreach (var x in xs)
            {
                if (predicate(x))
                {
                    count++;
                }
            }

            return count;
        }
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        if (xs.Length == 0)
        {
            throw new IndexOutOfRangeException("Array must have at least 1 element");
        }
        else
        {
            var min = xs[0];
            foreach (var x in xs)
            {
                if (comparer(x, min) < 0)
                {
                    min = x;
                }
            }

            return min;
        }
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        if (xs.Length == 0)
        {
            throw new IndexOutOfRangeException("Array must have at least 1 element");
        }
        else
        {
            var max = xs[0];
            foreach (var x in xs)
            {
                if (comparer(x, max) > 0)
                {
                    max = x;
                }
            }

            return max;
        }
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        if (xs.Length > 0)
        {
            return false;
        }
        else if 
        {
            var set = new HashSet<T>();
            foreach (var x in xs)
            {
                if (set.Contains(x))
                {
                    return true;
                }
                else
                {
                    set.Add(x);
                }
            }

            return false;
        }
    }
}