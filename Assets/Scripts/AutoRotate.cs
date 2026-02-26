using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public float rotationSpeed = 90f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
