using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework4 : MonoBehaviour
{
    /*
     - **�sszegz�s**
    �rj programot, ami bementet egy eg�sz sz�m `number` n�ven �s kisz�molja az els� `number` darab term�szetes sz�m �sszeg�t.
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
