using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Destroys whatever has collided with ME
            Destroy(other.gameObject);
        }
        
        // Destroys ME
        Destroy(gameObject);
    }
}
