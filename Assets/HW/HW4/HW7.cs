using UnityEngine;
/*
    �rj komponenst, aminek megadhatunk egy m�sik GameObject-et Transorm t�pus� [SerializeField] v�ltoz�ban. 
    A szkript�nk eltolja saj�t mag�t egy maxim�lis be�ll�that� t�vols�ggal a c�lpont ir�ny�ba a kezdeti poz�ci�j�hoz k�pest. 
    Ha a c�lpont k�zelebb van, mint a maxim�lis eltol�s, akkor az eltol�s kisebb.
 */
public class HW7 : MonoBehaviour
{
    [SerializeField] Transform target; // A c�lobjektum, amely fel� mozgunk
    [SerializeField] float maxOffset;  // A maxim�lis eltol�s m�rt�ke

    Vector3 startPostion; // Az objektum kezdeti poz�ci�ja

    void Start()
    {
        // Elmentj�k az objektum kezdeti poz�ci�j�t
        startPostion = transform.position;
    }

    void Update()
    {
        // Kisz�m�tjuk az objektum �s a c�lpont k�z�tti t�vols�gvektort:
        Vector3 distanceVector = target.position - transform.position;
        // Korl�tozzuk az eltol�s m�ret�t
        Vector3 offsetVector = Vector3.ClampMagnitude(distanceVector, maxOffset);

        // Az objektum �j poz�ci�ja a kezdeti poz�ci� �s az eltol�s �sszege
        transform.position = startPostion + offsetVector;
    }
}
