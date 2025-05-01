using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float MovementForce;
    public float JumpForce;

    private bool isJumping;
    private int counter;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        rb.AddForce(new Vector3(-verticalInput * MovementForce, 0f, horizontalInput * MovementForce), ForceMode.Force);

        if(isJumping && counter < 2)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            isJumping = false;
            counter++;
         
        }


    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
        }

        if(transform.position.y < 0.65f)
        {
            counter = 0;
        }
    }


}
