using UnityEngine;

public class RocketControl : MonoBehaviour
{
    
    public float MovementForce; // The force applied to the rocket when moving up
    public float RotationForce;
    Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // if(Input.GetKey(KeyCode.W))
        // {
        //     rb.AddRelativeForce(Vector3.up * MovementForce, ForceMode.Force);
        // }

        float verticalInput = Input.GetAxis("Vertical");
        rb.AddRelativeForce(Vector3.up * verticalInput * MovementForce, ForceMode.Force);

        float horizontalInput = Input.GetAxis("Horizontal");
        rb.AddRelativeTorque(Vector3.forward * horizontalInput * RotationForce, ForceMode.Force);
    }
}
