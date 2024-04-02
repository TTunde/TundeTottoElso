using UnityEngine;

/*
 - **Forgat�s a k�zelebbi ir�ny�ba**
    
    �rj komponenst, aminek megadhatunk kett� m�sik GameObject-et `Transorm` t�pus� `[SerializeField]` v�ltoz�ban. 
    A szkrip�nk kiv�lasztja a kett� k�z�l a k�zelebbit �s lassan elkezdi afel� ford�tja a saj�t felfel� ir�ny�t fix be�ll�that� sz�gsebess�ggel. 
    A komponens 2D-ben m�k�dik.
 */
public class HM6 : MonoBehaviour
{
    [SerializeField] Transform target1, target2;  // C�lpontok
    [SerializeField] float angularSpeed; // Sz�gsebess�g


    void Update()
    {
        // Sz�m�tjuk ki az objektum �s a c�l1, valamint az objektum �s a c�l2 k�z�tti t�vols�got
        float distance1 = Vector3.Distance(transform.position, target1.position);
        float distance2 = Vector3.Distance(transform.position, target2.position);

        // Kiv�lasztjuk a k�zelebbi c�lt az objektumhoz
        Vector3 targetPosition = distance1 < distance2 ? target1.position : target2.position;

        // Kisz�m�tjuk a c�l ir�ny�t az objektumhoz k�pest
        Vector3 targetDirection = (targetPosition - transform.position).normalized;

        // Sz�m�tjuk ki a c�lt ir�ny�t�s�ra haszn�lt elfordul�si ir�ny�t�st
        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, targetDirection);

        // Elforgatjuk az objektumot a c�l fel� az elfordul�si sebess�g �s az id�intervallum alapj�n
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, angularSpeed * Time.deltaTime);
    }
}

