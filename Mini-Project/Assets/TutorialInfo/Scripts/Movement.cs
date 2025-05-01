using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MovementForce;
    public float JumpForce;
    private bool isJumping = false;
    private int counter;

    Rigidbody rb;
    GameController gameController;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        gameController = GameObject.Find("GameManager").GetComponent<GameController>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");


        if (gameController.tag == "Level1")
        {
            rb.AddForce(new Vector3(-verticalInput * MovementForce, 0f, horizontalInput * MovementForce), ForceMode.Force);
        }
        else
        {
            rb.AddForce(new Vector3(verticalInput * MovementForce, 0f, -horizontalInput * MovementForce), ForceMode.Force);
        }

        if(isJumping == true && counter < 2)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            counter++;
            isJumping = false;
        }
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
        }

        if(transform.position.y < .65f)
        {
            counter = 0;
        }
    }
}
