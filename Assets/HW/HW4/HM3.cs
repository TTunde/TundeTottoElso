using UnityEngine;
/*- **Követés tisztes távolságból**
    Írj komponenst, aminek ha egy Transorm típusú `[SerializeField]` változóban megadunk egy másik GameObject-et, 
    akkor követi azt fix sebességgel, azaz folyamatosan megy felé úgy, hogy nem közelíti meg az teljesen. 
    Hogy mekkora távolságot tartunk a célobjektumtó egy másik beállíthatás adja meg.
    A komponensnek be kell állítani a haladási sebességet is. 
    (A beállított sebesség azt adja meg, hogy egy másodperc alatt mekkora utat tegyen meg a GameObject.)
*/

public class HM3 : MonoBehaviour
{
    [SerializeField] Transform followed;
    [SerializeField] float minDistance;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 targetPosition = followed.position;   // Követendõ pozíció, ezt a másik GObjectet adjuk oda
        Vector3 selfPosition = transform.position;  // Saját pozíció

        Vector3 movement = targetPosition - selfPosition; // Mozgás iránya
        float distance = movement.magnitude;              // Célponttávolsága

        if (distance <= minDistance)    // Ha már elég közel vagyunk,
            return;                      // akkor nem megyünk még közelebb
        movement.Normalize();
        transform.position += movement * (Time.deltaTime * speed);
    }
}

