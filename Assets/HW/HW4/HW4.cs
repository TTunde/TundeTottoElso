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
}
