using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework2Pitagorasz : MonoBehaviour
{
    /*
    Írj programot, ami bekéri egy háromszög oldalainak hosszát növekvõ sorrendben és kiszámolja, hogy a háromszög derékszögû-e!
    Az ilyen számokat Pitagoraszi számhármasnak is nevezzük.
    Három olyan egész szám, amiket ha oldalhosszként használunk egy háromszög megépítéséhez a keletkezett háromszög derékszögû lesz.
    A **Pitagorasz tétel** értelmében ezen (a, b, c) számokra igaz, hogy:
    a^2 + b^2 = c^2
    Híres pitagoraszi számhármas például a ( 3, 4, 5 )
    (3×3)+(4×4) = (5×5) 
    */

    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] int c;
    void OnValidate()
    {
        float ab = Mathf.Pow(a, 2) + Mathf.Pow(b, 2);
        if (Mathf.Pow(c, 2) == ab)
        {
            Debug.Log("A háromszög derékszögû háromszög");
        }
        else
        {
            Debug.Log("A háromszög NEN derékszögû háromszög");

        }

    }

}
