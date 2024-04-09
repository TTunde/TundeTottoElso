using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMGizmos : MonoBehaviour
{
    [SerializeField] float hossz;
    private void OnDrawGizmos()
    { Vector3 p = transform.position;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(p + transform.right, p - transform.right * hossz);
        Gizmos.DrawSphere(p + transform.right * hossz,  0.1f * hossz);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(p + transform.up, p - transform.up * hossz);
        Gizmos.DrawSphere(p + transform.up * hossz, 0.1f * hossz);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(p + transform.forward, p - transform.forward * hossz);
        Gizmos.DrawSphere(p + transform.forward * hossz, 0.1f * hossz);

    }
}
