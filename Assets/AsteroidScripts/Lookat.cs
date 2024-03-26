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
        Vector3 self = transform.position;  // Saját
        Vector3 other = toLookAt.position;  // Másik (Amit nézek)

        Vector3 direction = other - self;
        direction.Normalize();//ha .normalized van használva az az összes változóta külön meg kell hívni, mert egyénileg változik

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
        transform.position = Vector3.MoveTowards(self, other, speed* Time.deltaTime); //3 paraméter, mi a kiindulópont, cél pozíció, maxlépéstáv 
        //ha valamit közelíteni akarok valami máshoz túllépés nélkül akkor ezt kell használni
        //transform.position += step;
    }
}
