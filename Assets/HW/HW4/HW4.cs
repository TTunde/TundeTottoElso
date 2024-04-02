using UnityEngine;
/*
 - **K�zelebbi k�vet�se**
    �rj komponenst, aminek megadhatunk kett� m�sik  GameObject-et `Transorm` t�pus� `[SerializeField]` v�ltoz�ban. A szkrip�nk kiv�lasztja a kett� k�z�l a k�zelebbit �s afel� megy fix be�ll�that� sebess�ggel.
 */
public class HW4 : MonoBehaviour
{
    // K�vetend� transformok referenci�i
    [SerializeField] Transform target1, target2;  // C�lpontok
    [SerializeField] float speed = 1;             // Sebess�g 

    void Update()
    {
        Vector3 selfPosition = transform.position;  // Saj�t poz�ci�
                                                    // C�lpontok t�vols�gai:
        float distance1 = Vector3.Distance(target1.position, selfPosition);
        float distance2 = Vector3.Distance(target2.position, selfPosition);

        Transform target;               // Kiv�lasztjuk a k�zelebbit
        if (distance1 < distance2)
            target = target1;
        else
            target = target2;

        Vector3 targetPosition = target.position;   // K�vetend� poz�ci�

        Vector3 movement = targetPosition - selfPosition; // Mozg�s ir�nya
        movement.Normalize();                             // Ir�ny normaliz�l�sa

        // Sz�ks�ges szorozni a mozg�s ir�ny�t a sebess�g�vel
        // Sz�ks�ges szorozni a Time.deltaTime-mal,
        // hogy egy frame alatti utat tegye csak meg
        transform.position += movement * (Time.deltaTime * speed);
    }
}
