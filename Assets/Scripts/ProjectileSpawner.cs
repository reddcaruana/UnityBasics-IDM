using UnityEngine;
using UnityEngine.InputSystem;

public class ProjectileSpawner : MonoBehaviour
{
    // The template projectile
    public GameObject projectilePrefab;
    
    // The spawn position - a point in space
    public Transform spawnPoint;
    
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // Create a copy of the projectile
            Instantiate(projectilePrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
