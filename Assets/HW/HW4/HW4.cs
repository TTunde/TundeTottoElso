using UnityEngine;
/*
 - **Közelebbi követése**
    Írj komponenst, aminek megadhatunk kettõ másik  GameObject-et `Transorm` típusú `[SerializeField]` változóban. A szkripünk kiválasztja a kettõ közül a közelebbit és afelé megy fix beállítható sebességgel.
 */
public class HW4 : MonoBehaviour
{
    // Követendõ transformok referenciái
    [SerializeField] Transform target1, target2;  // Célpontok
    [SerializeField] float speed = 1;             // Sebesség 

    void Update()
    {
        Vector3 selfPosition = transform.position;  // Saját pozíció
                                                    // Célpontok távolságai:
        float distance1 = Vector3.Distance(target1.position, selfPosition);
        float distance2 = Vector3.Distance(target2.position, selfPosition);

        Transform target;               // Kiválasztjuk a közelebbit
        if (distance1 < distance2)
            target = target1;
        else
            target = target2;

        Vector3 targetPosition = target.position;   // Követendõ pozíció

        Vector3 movement = targetPosition - selfPosition; // Mozgás iránya
        movement.Normalize();                             // Irány normalizálása

        // Szükséges szorozni a mozgás irányát a sebességével
        // Szükséges szorozni a Time.deltaTime-mal,
        // hogy egy frame alatti utat tegye csak meg
        transform.position += movement * (Time.deltaTime * speed);
    }
    /*
     using UnityEngine;

public class FollowClosest : MonoBehaviour
{
    [SerializeField] Transform target1, target2;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 selfPos = transform.position;
        float d1 = Vector3.Distance(target1.position, selfPos);
        float d2 = Vector3.Distance(target2.position, selfPos);


    //Vector3 targetPositon = d1 < d2 ? target1.poition : target2.position; ---ez is jó


        Transform target;
        if (d1 < d2)
            target = target1;
        else
            target = target2;

        transform.position =
            Vector3.MoveTowards(selfPos, target.position, speed * Time.deltaTime);
    }

}
*/
}
