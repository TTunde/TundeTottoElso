using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5;
    [SerializeField] float maxAngularSpeed = 90;
    private void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = Random.Range(-maxAngularSpeed, maxAngularSpeed);

        //float x = Random.Range(-maxSpeed, maxSpeed);
        //float y = Random.Range(-maxSpeed, maxSpeed);
        Vector2 v = Random.insideUnitCircle * maxSpeed; // vissza fog adni egy 1 egység kör 
        rb.velocity = v; 

    }

    private void OnDestroy() //ez a start ellenkezõje
    {
        FindObjectOfType<AsteroidSpawner>().RemoveAsteroid(this);
    }
}
