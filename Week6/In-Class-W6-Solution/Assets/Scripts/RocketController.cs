using UnityEngine;

public class RocketController : MonoBehaviour
{
    public float MovementForce;
    public float RotationForce;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // if(Input.GetKey(KeyCode.W))
        // {
        //     rb.AddRelativeForce(Vector3.up * MovementForce, ForceMode.Force);
        // }

        // Apply Force
        float verticalInput = Input.GetAxis("Vertical");
        rb.AddRelativeForce(Vector3.up * MovementForce * verticalInput, ForceMode.Force);

        // Apply Torque
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.AddRelativeTorque(Vector3.forward * RotationForce * horizontalInput, ForceMode.Force);

    }
}
