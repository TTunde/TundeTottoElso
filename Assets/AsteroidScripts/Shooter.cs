using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrototype;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(bulletPrototype); // másolatot készít
            newBullet.transform.position = transform.position;
            newBullet.transform.rotation = transform.rotation;
            newBullet.SetActive(true);


        }
    }
}
