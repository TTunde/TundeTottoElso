using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework7Szorzotabla : MonoBehaviour
{
    /*
     Írj programot, ami kiírja a szorzótáblát!
    - Elvárt kimenet
        1 * 1 = 1
        2 * 1 = 2 
        … 
        9 * 10 = 90
        10 * 10 = 100
     */
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Debug.Log(i + " * " + j + " = " + i * j);
            }
        }
    }


}
