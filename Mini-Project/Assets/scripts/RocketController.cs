using Unity.VisualScripting;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public float movementForce;
    public float torqueForce;    
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // if(Input.GetKey(KeyCode.W))
        // {
        //     rb.AddRelativeForce(Vector3.up * movementForce, ForceMode.Force);
        // }

        float verticalInput = Input.GetAxis("Vertical");
        rb.AddRelativeTorque(Vector3.forward * torqueForce * verticalInput, ForceMode.Force);

        float horizontalInput = Input.GetAxis("Horizonal");
        rb.AddRelativeTorque(Vector3.forward * torqueForce * horizontalInput, ForceMode.Force);

    }
}
