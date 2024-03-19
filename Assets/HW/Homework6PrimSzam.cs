using UnityEngine;

public class Homework6PrimSzam : MonoBehaviour
{
    /*
     Eldöntés(N,X,VAN):
        I:=1
        Ciklus amíg I≤N és nem T(X[I])
            I:=I+1
        Ciklus vége
    VAN:=(I≤N)
    Eljárás vége.
     */

    //Írj programot, ami egy bemeneti egész számról eldönti és kiírja, hogy prím-e.

    [SerializeField] int number;
    [SerializeField] bool primE = true;
    void Start()
    {
        int i = 2;
        while (i < number && (number % i != 0))
        {
            i++;
        }
        if (i == number)
        {
            Debug.Log(number + "  Prímszám");
        }
        else
        {
            Debug.Log(number + " N-Prímszám");
        }


        for (int j = 1; j < number; j++)
        {
            if (number % j == 0)
            {
                primE = false;
                break;
            }
        }
    }
}
