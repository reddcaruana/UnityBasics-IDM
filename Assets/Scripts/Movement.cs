using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Rigidbody myRigidbody;
    
    public float speed = 10.5f;
    public float rotationSpeed = 180f;
    
    // Update is called once per frame
    void Update()
    {
        // No direction or rotation when the frame starts
        Vector3 direction = Vector3.zero;
        float rotationAngle = 0f;
        
        // Forward/Back movement
        if (Keyboard.current.wKey.isPressed)
        {
            // direction.y = 1;
            direction = transform.up;
        }

        if (Keyboard.current.sKey.isPressed)
        {
            // direction.y = -1;
            direction = transform.up * -1;
            // because transform.down doesn't exist
        }
        
        // Left/Right Rotation
        if (Keyboard.current.aKey.isPressed)
        {
            rotationAngle = -1;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            rotationAngle = 1;
        }
        
        myRigidbody.AddForce(direction * speed * Time.deltaTime);
        myRigidbody.AddTorque(Vector3.back * rotationAngle * rotationSpeed * Time.deltaTime);

        // transform.Translate(direction * Time.deltaTime * speed);
        // transform.Rotate(Vector3.back, rotationAngle * rotationSpeed * Time.deltaTime);
        // Time.deltaTime -> the time between two frames
    }
}
