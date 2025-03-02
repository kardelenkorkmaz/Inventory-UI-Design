using UnityEngine;

public class RotateObject : MonoBehaviour
{
    
    public float rotationSpeed = 5f; // Adjust speed

    private Vector3 lastMousePosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // On first touch/click
        {
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0)) // While dragging
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;
            transform.Rotate(Vector3.up, -delta.x * rotationSpeed * Time.deltaTime, Space.World);
            lastMousePosition = Input.mousePosition;
        }
    }
}