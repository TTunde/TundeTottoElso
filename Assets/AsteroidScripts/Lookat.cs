using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Lookat : MonoBehaviour
{
    [SerializeField] Transform toLookAt;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 self = transform.position;  // Saj�t
        Vector3 other = toLookAt.position;  // M�sik (Amit n�zek)

        Vector3 direction = other - self;
        direction.Normalize();//ha .normalized van haszn�lva az az �sszes v�ltoz�ta k�l�n meg kell h�vni, mert egy�nileg v�ltozik

        if (direction != Vector3.zero)
        {
        transform.rotation = Quaternion.LookRotation(direction);
        }
        /*
        Vector3 step = direction * speed * Time.deltaTime;

        float stepLength = step.magnitude;
        float fullDistance = Vector3.Distance(self, other);
        if (stepLength > fullDistance)
        {
            step = direction * fullDistance;
        }
        */
        transform.position = Vector3.MoveTowards(self, other, speed* Time.deltaTime); //3 param�ter, mi a kiindul�pont, c�l poz�ci�, maxl�p�st�v 
        //ha valamit k�zel�teni akarok valami m�shoz t�ll�p�s n�lk�l akkor ezt kell haszn�lni
        //transform.position += step;
    }
}
