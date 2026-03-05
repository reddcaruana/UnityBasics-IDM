using UnityEngine;
using UnityEngine.InputSystem;

public class ModernMovement : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float speed = 10f;
    
    // The player's total movement
    private Vector3 direction = Vector3.zero;
    
    // Update is called once per frame
    void Update()
    {
        direction = Vector3.zero;
        
        if (Keyboard.current.wKey.isPressed)
        {
            direction.z = 1;
        }

        if (Keyboard.current.sKey.isPressed)
        {
            direction.z = -1;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            direction.x = -1;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            direction.x = 1;
        }
        
        // Standardizes movement in all directions
        direction.Normalize();
    }

    // Physics update - 50fps
    private void FixedUpdate()
    {
        // Adjusts movement speed
        myRigidbody.linearVelocity = direction * speed;
        
        // Checks if there is movement
        // If zero = no movement
        if (direction.sqrMagnitude > 0.1f)
        {
            // Adjusts rotation
            myRigidbody.rotation = Quaternion.LookRotation(direction);
        }
    }
}
