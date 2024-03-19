using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework4 : MonoBehaviour
{
    /*
     - **Összegzés**
    Írj programot, ami bementet egy egész szám `number` néven és kiszámolja az elsõ `number` darab természetes szám összegét.
     */

    [SerializeField] int number;
    int counter = 0;

    void Start()
    {
        for (int i = 1; i <= number; i++)
        {
            counter += i;
        }    
        Debug.Log("Number = " + counter);
    }

}
