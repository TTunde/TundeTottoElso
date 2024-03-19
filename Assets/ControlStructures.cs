using UnityEngine;

public class ControlStructures : MonoBehaviour
{
    [SerializeField] int ammo = 10;

    private void Start()
    {
        ////írjuk ki az elsõ 10 számot
        //int i = 1;
        //while (i <=10)
        //{
        //    Debug.Log(i);
        //    i++;
        //}
        //Debug.Log("Vége");
        ////----------------

        //for (int j = 1; j <= 100; j++)
        //{
        //    Debug.Log(j);
        //}

       /* for (int k = 1; k <= 10; k++)
        {
            float number = Mathf.Pow(k, 2);
            Debug.Log(number);
        }

        for (int m = 1; m <= 100; m++)
        {

            if (m%2 ==1)
            {
                Debug.Log("páratlan = " + m);
            }
        }*/
    }
    void Update() //minden képfrissítéskor lefut
    {
        bool pressKey = Input.GetKeyDown(KeyCode.Space);

        if (pressKey)
        {
            if (ammo > 0)
            {
                Debug.Log("Bang!");
                ammo--;
            }
            else
            {
                Debug.Log("Katt");
            }
        }
    }
}
