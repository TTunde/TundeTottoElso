using UnityEngine;
/*
    Írj komponenst, aminek megadhatunk egy másik GameObject-et Transorm típusú [SerializeField] változóban. 
    A szkriptünk eltolja saját magát egy maximális beállítható távolsággal a célpont irányába a kezdeti pozíciójához képest. 
    Ha a célpont közelebb van, mint a maximális eltolás, akkor az eltolás kisebb.
 */
public class HW7 : MonoBehaviour
{
    [SerializeField] Transform target; // A célobjektum, amely felé mozgunk
    [SerializeField] float maxOffset;  // A maximális eltolás mértéke

    Vector3 startPostion; // Az objektum kezdeti pozíciója

    void Start()
    {
        // Elmentjük az objektum kezdeti pozícióját
        startPostion = transform.position;
    }

    void Update()
    {
        // Kiszámítjuk az objektum és a célpont közötti távolságvektort:
        Vector3 distanceVector = target.position - transform.position;
        // Korlátozzuk az eltolás méretét
        Vector3 offsetVector = Vector3.ClampMagnitude(distanceVector, maxOffset);

        // Az objektum új pozíciója a kezdeti pozíció és az eltolás összege
        transform.position = startPostion + offsetVector;
    }
}
