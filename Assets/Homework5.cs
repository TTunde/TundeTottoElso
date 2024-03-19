using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework5 : MonoBehaviour
{
    /*
    �rj programot, aminek a bemenete egy eg�sz sz�m `number` n�ven!
    A programot ki�rja a sz�mokat a konzolra 1-t�l `number`-ig, de�
     - Ha a sz�m 3 t�bbsz�r�se, a sz�m helyett: `"Fizz"`-t �rjon!
     - Ha a sz�m 5 t�bbsz�r�se, akkor `"Buzz"`-t �rjon!
     - Ha a sz�m 3 �s 5 t�bbsz�r�se is, akkor `"FizzBuzz"`-t �rjon!
     - Minden egy�b esetben a sz�mot mag�t �rja ki!
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
