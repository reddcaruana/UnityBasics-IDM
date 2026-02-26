using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Triggers when this object connects with
        // a trigger collider.
        
        // One object needs a Rigidbody
        // Both objects need a collider
        // for this to work
        
        Debug.Log($"Collided with {other.name}");
        
        // We are destroying the thing we collided with
        Destroy(other.gameObject);
    }
}
