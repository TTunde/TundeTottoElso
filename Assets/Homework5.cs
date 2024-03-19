using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework5 : MonoBehaviour
{
    /*
    Írj programot, aminek a bemenete egy egész szám `number` néven!
    A programot kiírja a számokat a konzolra 1-tõl `number`-ig, de…
     - Ha a szám 3 többszöröse, a szám helyett: `"Fizz"`-t írjon!
     - Ha a szám 5 többszöröse, akkor `"Buzz"`-t írjon!
     - Ha a szám 3 és 5 többszöröse is, akkor `"FizzBuzz"`-t írjon!
     - Minden egyéb esetben a számot magát írja ki!
     */

    [SerializeField] int number;
    void Start()
    {
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("Fizz Buzz");
            }
            else if (i % 5 == 0)
            {
                Debug.Log("Buzz");

            }
            else if (i % 3 == 0 )
            {
                Debug.Log("Fizz");
            }
            else
            {
                Debug.Log("Number= " + i);
            }
        }
    }

    
}
