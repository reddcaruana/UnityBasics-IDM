using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public int health = 100;
    
    public float speed = 10.5f;
    public float rotationSpeed = 180f;
    
    public string playerName = "Ben Dover";
    public bool isAlive = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Hello, my name is {playerName}");
    }

    // Update is called once per frame
    void Update()
    {
        // No direction or rotation when the frame starts
        Vector3 direction = Vector3.zero;
        float rotationAngle = 0f;
        
        // Forward/Back movement
        if (Keyboard.current.wKey.isPressed)
        {
            direction.y = 1;
        }

        if (Keyboard.current.sKey.isPressed)
        {
            direction.y = -1;
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

        transform.Translate(direction * Time.deltaTime * speed);
        transform.Rotate(Vector3.back, rotationAngle * rotationSpeed * Time.deltaTime);
        // Time.deltaTime -> the time between two frames
    }
}
