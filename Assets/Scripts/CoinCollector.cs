using TMPro;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public TMP_Text uiText;
    public int score;
    
    private void OnTriggerEnter(Collider other)
    {
        // Triggers when this object connects with
        // a trigger collider.
        
        // One object needs a Rigidbody
        // Both objects need a collider
        // for this to work
        
        Debug.Log($"Collided with {other.name}");
        
        // Increase the score
        score += 1;
        uiText.text = $"Score: {score}";
        
        // We are destroying the thing we collided with
        Destroy(other.gameObject);
    }
}
