using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VektorPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 myVector = new Vector2(2,3);
        float x = myVector.x;
        float y = myVector.y;

        Vector2 myOtherVector = new(4, 9);
        Vector2 summa = myVector + myOtherVector;

        Vector2 diff = myVector - myOtherVector;
        Vector2 multi = diff * 5;
        Vector2 div = summa / 2;


        // Hossz kiszámítása
        float vectorHossz = summa.magnitude;

        //Egy egység vektor - normalizálás
        Vector2 normalized = summa.normalized;
        
    }

}
