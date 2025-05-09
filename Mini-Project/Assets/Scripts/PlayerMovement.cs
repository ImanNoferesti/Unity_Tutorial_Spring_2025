using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Player Variable
    public float PlayerForce;
    public float JumpForce;
    Rigidbody Sphere;
    public bool levelTwo;

    public Transform playerSphere;
    private bool isJumping;

    private int counter;


    
    
    void Start()
    {
        if (gameObject.tag == "Sphere")
        {
            Sphere = gameObject.GetComponent<Rigidbody>();
            playerSphere = transform;
        }
    }

    void FixedUpdate()
    {
        if (gameObject.tag == "Sphere")
        {
            float xInput = Input.GetAxis("Horizontal");
            float zInput = Input.GetAxis("Vertical");
            float jumpInput = Input.GetAxis("Jump");
            

            Sphere.AddForce(new Vector3(zInput * -PlayerForce, 0f, 0f), ForceMode.Force);
            Sphere.AddForce(new Vector3(0f, 0f, xInput * PlayerForce), ForceMode.Force);
            
            if (isJumping & counter < 2)
            {
                
                Sphere.AddForce(new Vector3(0f, JumpForce, 0f), ForceMode.Impulse);
                isJumping = false;
                counter++;
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gameObject.tag == "Sphere")
        {
            if (transform.position.y < .6f)
                {
                    counter = 0;
                }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isJumping = true;
            }
        }
    }
    void LateUpdate() 
    {
        Debug.Log(levelTwo);
        if (gameObject.tag == "MainCamera")
        {
            transform.position = new Vector3(playerSphere.position.x + 3.4f, playerSphere.position.y + 2.01f, playerSphere.position.z);
            if (levelTwo == true)
            {
                
                transform.position = new Vector3(playerSphere.position.x - 3.4f, playerSphere.position.y + 2.01f, playerSphere.position.z);
            }
        }
    }
}
