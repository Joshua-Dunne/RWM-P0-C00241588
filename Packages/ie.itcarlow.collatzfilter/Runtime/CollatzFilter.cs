using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollatzFilter
{
    public static int odd(int x)
    {
        return (3 * x) + 1;
    }

    public static int even(int x)
    {
        return x / 2;
    }

    public static int[] collatz(int[] xs)
    {
        int[] result = new int[xs.Length];

        for (int i = 0; i < xs.Length; i++)
        {
            if (xs[i] % 2 == 0)
                result[i] = even(xs[i]);
            else
                result[i] = odd(xs[i]);
        }

        return result;
    }
}
