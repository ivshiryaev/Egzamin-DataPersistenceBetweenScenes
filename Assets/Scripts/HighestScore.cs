using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighestScore : MonoBehaviour
{
    public static int Value { get; set; }

    public static void SaveHighScore(int value)
    {
        if (IsValueHigherThenCurrentHighScore(value))
        {
            Value = value;
        }
    }

    private static bool IsValueHigherThenCurrentHighScore(int value)
    {
        return value > Value ? true : false;
    }
}
