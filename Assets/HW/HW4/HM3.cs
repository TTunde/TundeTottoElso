using UnityEngine;
/*- **K�vet�s tisztes t�vols�gb�l**
    �rj komponenst, aminek ha egy Transorm t�pus� `[SerializeField]` v�ltoz�ban megadunk egy m�sik GameObject-et, 
    akkor k�veti azt fix sebess�ggel, azaz folyamatosan megy fel� �gy, hogy nem k�zel�ti meg az teljesen. 
    Hogy mekkora t�vols�got tartunk a c�lobjektumt� egy m�sik be�ll�that�s adja meg.
    A komponensnek be kell �ll�tani a halad�si sebess�get is. 
    (A be�ll�tott sebess�g azt adja meg, hogy egy m�sodperc alatt mekkora utat tegyen meg a GameObject.)
*/

public class HM3 : MonoBehaviour
{
    [SerializeField] Transform followed;
    [SerializeField] float minDistance;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 targetPosition = followed.position;   // K�vetend� poz�ci�, ezt a m�sik GObjectet adjuk oda
        Vector3 selfPosition = transform.position;  // Saj�t poz�ci�

        Vector3 movement = targetPosition - selfPosition; // Mozg�s ir�nya
        float distance = movement.magnitude;              // C�lpontt�vols�ga

        if (distance <= minDistance)    // Ha m�r el�g k�zel vagyunk,
            return;                      // akkor nem megy�nk m�g k�zelebb
        movement.Normalize();
        transform.position += movement * (Time.deltaTime * speed);
    }
}

