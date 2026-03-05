using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject thingToSpawn;
    
    // An array is a collection of items
    // of the same data type
    public Transform[] spawnPoints;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(
            "Spawn",
            1f,
            2f);
    }

    // Spawns a thing in the scene
    // at a random point
    private void Spawn()
    {
        // 1. Get a random number
        int index = Random.Range(0, spawnPoints.Length);
        
        // Temporarily stores the right spawn point
        Transform point = spawnPoints[index];

        // 2. Spawn an item on the spawn point
        Instantiate(thingToSpawn, point.position, point.rotation);
    }
}
