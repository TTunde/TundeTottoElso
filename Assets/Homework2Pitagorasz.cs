using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework2Pitagorasz : MonoBehaviour
{
    /*
    �rj programot, ami bek�ri egy h�romsz�g oldalainak hossz�t n�vekv� sorrendben �s kisz�molja, hogy a h�romsz�g der�ksz�g�-e!
    Az ilyen sz�mokat Pitagoraszi sz�mh�rmasnak is nevezz�k.
    H�rom olyan eg�sz sz�m, amiket ha oldalhosszk�nt haszn�lunk egy h�romsz�g meg�p�t�s�hez a keletkezett h�romsz�g der�ksz�g� lesz.
    A **Pitagorasz t�tel** �rtelm�ben ezen (a, b, c) sz�mokra igaz, hogy:
    a^2 + b^2 = c^2
    H�res pitagoraszi sz�mh�rmas p�ld�ul a ( 3, 4, 5 )
    (3�3)+(4�4) = (5�5) 
    */

    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] int c;
    void OnValidate()
    {
        float ab = Mathf.Pow(a, 2) + Mathf.Pow(b, 2);
        if (Mathf.Pow(c, 2) == ab)
        {
            Debug.Log("A h�romsz�g der�ksz�g� h�romsz�g");
        }
        else
        {
            Debug.Log("A h�romsz�g NEN der�ksz�g� h�romsz�g");

        }

    }

}
