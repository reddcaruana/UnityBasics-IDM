using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Destroys whatever has collided with ME
        Destroy(other.gameObject);
        
        // Destroys ME
        Destroy(gameObject);
    }
}
