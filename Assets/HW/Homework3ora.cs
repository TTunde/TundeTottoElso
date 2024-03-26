using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework3ora : MonoBehaviour
{

    float myClampMethod(float value, float a, float b)
    {
        if (value < a)
        {
            return a;
        }
        else if (value > b)
        {
            return b;
        }
        else
        {
            return value;
        }
    }

    /*float myClampMethod012(float value)
    {
        return myClampMethod(value, 0, 1f);
    }*/

    float myClampMethod01(float value)
    {
        if (value < 0)
        {
            return 0;
        }
        else if (value > 1)
        {
            return 1;
        }
        else
        {
            return value;
        }
    }
   
        /*
         �rj�tok meg a saj�t float verzi�tokat a k�vetkez� eg�szre kerekt� f�ggv�nyekb�l:
        - `float **Math.Floor**( float number )`             (Unity-ben `Mathf.Floor`)
        - `float **Math.Ceiling**( float number )`          (Unity-ben `Mathf.Ceil`)
        - `float **Math.Round**( float number )`             (Unity-ben `Mathf.Round`)
        Ha sz�ks�ges, n�zzetek ut�na a megadott f�ggv�nyek m�k�d�s�nek a C# dokument�ci�ban! (A Google a bar�totok.)
        Javaslat: A fent megadott sorrendben k�sz�tsd el a f�ggv�nyeket!
        A negat�v tartom�nyban nem k�telez�, hogy m�k�djenek a f�ggv�ny.
         */

    int myFloorMethod(float a)
    {
        int szam = (int)a;
        //float maradek = num % 1;
        //return num - maradek;
        return szam;
    }


    int myCeilMethod(float b)
    {
        return myFloorMethod(b + 1);
        //eg�sz sz�mokra nem m�k�dik
    }
   

    int myRoundMethod(float c)
    {
        int szam = myFloorMethod(c);
        float maradek = c - szam;
        if (maradek >= 0.5)
        {
            return myCeilMethod(c);
        }
        else
        {
            return szam;
        }
    }
    

    int myRoundMethodB(float c)
    {
        int szam = myFloorMethod(c);
        float maradek = c - szam;
        return maradek >= 0.5 ? myCeilMethod(c) : szam;

    }

    /*
     �rj met�dust, ami ki�rja az els� `n` darab pr�msz�mot!
    `n` eg�sz sz�mot param�terben kapja meg a f�ggv�ny.
     */

    void WritePrimes(int n)
    {
        int counter = 0;
        for (int i = 2; counter < n; i++)
        {
            if (IsPrime(i))
            {
                Debug.Log(i);
                counter++;
            }
        }
    }


    bool IsPrime(int number)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }


    /*
    �rj f�ggv�nyt, ami visszaadja 2 darab `Vector2` t�pus� param�terk�nt kapott helyvektor t�vols�g�t.
    A megold�shoz ne haszn�ld a `Vector2.Distance` met�dust!
    */
    float myDistanceMethod(Vector2 a, Vector2 b)
    {
        float num = a.x - b.x;
        float num2 = a.y - b.y;
        float c = (num * num) + (num2 * num2);
        return Mathf.Sqrt(c);

        //return (a - b).magnitude; �rai megold�s
    }
   
    /*
    - **Ir�nyvektor pontb�l pontba**
    �rj f�ggv�nyt, ami 2 helyvektort kap `Vector3` t�pus� param�terk�nt!
    A f�ggv�nyt visszaadja `a` pontb�l `b` pontba mutat�, 1 egys�g hossz�s�g� vektort.
    */
    Vector3 myDirectionVector(Vector3 a, Vector3 b)
    {
        Vector3 dif = new Vector3((b.x - a.x), (b.y - a.y), (b.z - a.z));
        float vectorhossz = dif.magnitude;
        return dif.normalized;
    }

    Vector3 UnitVectorToB(Vector3 a, Vector3 b)
    {
        return (b - a).normalized;// mindig az van el�l ami fel� mutat
    }

    //�rai megold�sok
    float Clamp(float value, float min, float max)
    {
        if (max < min)
        {
            float t = min;
            min = max;
            max = t;
        }

        if (value < min)
            return min;

        if (value > max)
            return max;

        return value;
    }

    float Clamp01(float value)
    {
        return Clamp(value, 0, 1);
    }

    float Floor(float number)
    {
        float remainder = number % 1;
        return number - remainder;
    }

    float Ceil(float number)
    {
        float remainder = number % 1;
        if (remainder == 0)
            return number;

        return number - remainder + 1;
    }

    float Round(float number)
    {
        float remainder = number % 1;

        if (remainder >= 0.5f)
            return Ceil(number);
        else
            return Floor(number);
    }


    void WritePrimes2(int n)
    {
        int counter = 0;
        for (int i = 2; counter < n; i++)
        {
            if (IsPrime(i))
            {
                Debug.Log(i);
                counter++;
            }
        }
    }

    bool IsPrime2(int number)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
