using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;       // The object to spawn
    public float spawnInterval = 5f;       // Interval between spawns
    private float lastSpawnTime;           // Time of the last spawn

    void Update()
    {
        // Check if enough time has passed to spawn the object
        if (Time.time >= lastSpawnTime + spawnInterval)
        {
            SpawnObject();
            lastSpawnTime = Time.time;  // Update last spawn time
        }
    }

    void SpawnObject()
    {
        if (objectToSpawn != null)
        {
            // Instantiate the object at the spawner's position and rotation
            Instantiate(objectToSpawn, transform.position, transform.rotation);
        }
        else
        {
            // Log a warning if no object is assigned to spawn
            Debug.LogWarning("Object to spawn is not set.");
        }
    }
}
