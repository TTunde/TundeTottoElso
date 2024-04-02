using UnityEngine;

/*
 Írj “menekülõ” szkriptet, aminek megadható egy “üldözõ” GameObject, amitõl “menekül”!
A  “menekülõ” akkor kezd el “menekülni”, ha egy beállítható minimum távolságon belül van az “üldözõ”-höz képest, és akkor hagyja abba azt, ha kívül kerül ezen a távolságon.
A “menekülés” úgy történik, hogy a menekülõ egy fix beállítható gyorsulással növeli a saját sebességét az üldözõtõl távolodó irányba. Amikor nincs “menekülõ” állapot, akkor fix lassulással a 0 sebességet próbálja elérni a “menekülõ”.
Opcionális: Megadható egy max sebesség a menekülõnek.
 */
public class HM5 : MonoBehaviour
{
    [SerializeField] Transform chaser;   // Az az objektum, amely üldözi ezt az objektumot 
    [SerializeField] float minDistance;  // A minimális távolság, amelyen belül a menekülési viselkedés elkezdõdik
    [SerializeField] float acceleration; // A menekülés gyorsulásának (és lassulásának) mértéke
    [SerializeField] float maxSpeed;     // Az objektum által elérhetõ maximális sebesség

    Vector3 velocity; // Az objektum jelenlegi sebességvektora

    void Update()
    {
        // Számítjuk ki az objektum és az üldözõ közötti távolságvektort és hosszát
        Vector3 distanceVector = (transform.position - chaser.position);
        float distance = distanceVector.magnitude;

        bool isFleeing = distance < minDistance; // Éppen menekülünk-e?

        if (isFleeing) // Ha menekülünk, akkor...
        {
            // A távolság alapján számítjuk ki az üldözõ irányítására használni kívánt irányvektort
            Vector3 direction = distanceVector / distance; // Normalizálás
                                                           // ...növeljük a sebességet az irányításhoz
            velocity += acceleration * Time.deltaTime * direction;
            //és végül korlátozzuk a sebességet, ha túl nagy lenne
            velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        }
        else // Ha nem menekülünk, akkor...
        {
            // ...lassítsuk le a sebességet a nulla felé
            velocity = Vector3.MoveTowards(velocity, Vector3.zero, acceleration * Time.deltaTime);
        }

        // Lépünk egyet: Frissítjük az objektum pozícióját a sebességvektor és a idõintervallum szorzatával
        transform.position += velocity * Time.deltaTime;
    }
}
