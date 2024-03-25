using UnityEngine;

public class Spaceship : MonoBehaviour
{

    [SerializeField] float speed = 5;
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //-1 és 1 közötti értéket kérdezek le, de ha RAW-t rakunk mellé akkor 0 v 1
        float y = Input.GetAxisRaw("Vertical");

        Vector3 direction = new(x, y, 0);
        direction.Normalize();
        Vector3 step = direction * speed * Time.deltaTime;
        transform.position += step;

        //step *= Time.deltaTime;
        //step *= speed;

        //Vector2 position = transform.position;
        //Vector2 newPosition = position + step;
        //transform.position = newPosition;
    }
    private void Start()
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

        float num1 = myClampMethod(10, 5.5f, 18.9f);
        float num2 = myClampMethod(22.2f, 5.5f, 18.9f);
        float num3 = myClampMethod(1f, 5.5f, 18.9f);
        Debug.Log("Szám1: " + num1 + "Szám2: " + num2 + "Szám3: " + num3);

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
        Debug.Log("myClamp01: " + myClampMethod01(10) + " myClamp01: " + myClampMethod01(0.5f) + " myClamp01: " + myClampMethod01(1));

        /*
         Írjátok meg a saját float verziótokat a következõ egészre kerektõ függvényekbõl:
        - `float **Math.Floor**( float number )`             (Unity-ben `Mathf.Floor`)
        - `float **Math.Ceiling**( float number )`          (Unity-ben `Mathf.Ceil`)
        - `float **Math.Round**( float number )`             (Unity-ben `Mathf.Round`)
        Ha szükséges, nézzetek utána a megadott függvények mûködésének a C# dokumentációban! (A Google a barátotok.)
        Javaslat: A fent megadott sorrendben készítsd el a függvényeket!
        A negatív tartományban nem kötelezõ, hogy mûködjenek a függvény.
         */

        int myFloorMethod(float a)
        {
            int szam = (int)a;
            return szam;
        }
        Debug.Log("myFloorMethod" + myFloorMethod(5.88974f));

        int myCeilMethod(float b)
        {
            return myFloorMethod(b + 1);
        }
        Debug.Log("myCeilMethod" + myCeilMethod(5.88974f));

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
        Debug.Log("myRoundMethod" + myRoundMethod(5.48974f));

        int myRoundMethodB(float c)
        {
            int szam = myFloorMethod(c);
            float maradek = c - szam;
            return maradek >= 0.5 ? myCeilMethod(c) : szam;

        }

        /*
         Írj metódust, ami kiírja az elsõ `n` darab prímszámot!
        `n` egész számot paraméterben kapja meg a függvény.
         */

        /*
         Írj függvényt, ami visszaadja 2 darab `Vector2` típusú paraméterként kapott helyvektor távolságát.
         A megoldáshoz ne használd a `Vector2.Distance` metódust!
        */

        float myDistanceMethod(Vector2 a, Vector2 b)
        {
            float num = a.x - b.x;
            float num2 = a.y - b.y;
            float c = (num * num) + (num2 * num2);
            return Mathf.Sqrt(c);

        }
        Debug.Log("myDistanceMethod: " + myDistanceMethod(new Vector2(1, 2), new Vector2(3, 4)));


        /*
         - **Irányvektor pontból pontba**
        Írj függvényt, ami 2 helyvektort kap `Vector3` típusú paraméterként!
      A függvényt visszaadja `a` pontból `b` pontba mutató, 1 egység hosszúságú vektort.
         */
        Vector3 myDirectionVector(Vector3 a, Vector3 b)
        {
            Vector3 dif = new Vector3((b.x - a.x), (b.y - a.y), (b.z - a.z));
            float vectorhossz = dif.magnitude;
            return dif.normalized;


        }
    }
}
