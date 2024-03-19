using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework1OsszeadasSzovegesen : MonoBehaviour
{
    /*
    - **Összeadás szövegesen**
    Írj programot, ami kiírja a, és b egész `int` számok összegét az művelettel együtt!
    Például: Ha a bemenet 4 és 7, akkor a következő legyen a kimeneti `string` változó tartalma:
    `”4 + 7 = 11”`
    */
    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] string r;
    void Start()
    {
        Debug.Log(a + "+" + b + "=" + (a + b));
       r =  $"{a} + {b} = {a + b}";
    }
}
