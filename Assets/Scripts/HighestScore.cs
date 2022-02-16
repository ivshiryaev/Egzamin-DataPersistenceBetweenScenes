using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighestScore : MonoBehaviour
{
    public static int Value { get; set; }

    private void Awake()
    {
        
    }
    private void Start()
    {
        if(Value == 0)
            Value = 0;
    }
}
