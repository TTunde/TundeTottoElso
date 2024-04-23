using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{

    [SerializeField] int spawnCount;
    [SerializeField] Asteroid[] asteoridPrefabs;
    [SerializeField] float spawnDistance = 5;
    List<Asteroid> currentAsteroids = new List<Asteroid>();//Amik a sceneben léteznek

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            int randomIndex = Random.Range(0, asteoridPrefabs.Length);
            Asteroid prefab = asteoridPrefabs[randomIndex];
            Asteroid newAsteroid = Instantiate(prefab);
            currentAsteroids.Add(newAsteroid);

            Vector2 position = Random.insideUnitCircle;
            position.Normalize();
            position *= spawnDistance;
            newAsteroid.transform.position = position;
        }
    }

    public void RemoveAsteroid(Asteroid asteroid)
    {
        currentAsteroids.Remove(asteroid);
        if (currentAsteroids.Count ==0)
        {
            Debug.Log("Stage Clear!");
        }
    }
}
