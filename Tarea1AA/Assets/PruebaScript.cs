﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("I'm about to hit the ground!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int[] BubbleSort(int[] arr)
    {


        int temp = 0;

        for (int write = 0; write < arr.Length; write++)
        {
            for (int sort = 0; sort < arr.Length - 1; sort++)
            {
                if (arr[sort] > arr[sort + 1])
                {
                    temp = arr[sort + 1];
                    arr[sort + 1] = arr[sort];
                    arr[sort] = temp;
                }
            }

        }

        return arr;
    }
}
    


