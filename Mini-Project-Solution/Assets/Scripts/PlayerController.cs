using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float MovementForce;
    public float JumpForce;

    private bool isJumping;
    private int counter;

    Rigidbody rb;

    GameController gameController;

    AudioSource audioSource;

    TriggerDetector triggerDetector;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameController = GameObject.Find("GameManager").GetComponent<GameController>();
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = gameController.audioClips[1];
        audioSource.playOnAwake = false;
        audioSource.loop = false;
    }


    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if(gameController.tag == "Level1")
        {
            rb.AddForce(new Vector3(-verticalInput * MovementForce, 0f, horizontalInput * MovementForce), ForceMode.Force);
        }

        else if(gameController.tag == "Level2")
        {
            rb.AddForce(new Vector3(verticalInput * MovementForce, 0f, -horizontalInput * MovementForce), ForceMode.Force);
        }
        

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
            audioSource.Play();
        }

        if(transform.position.y < 0.65f)
        {
            counter = 0;
        }

        if(gameController.StarHit)
        {
            audioSource.PlayOneShot(gameController.audioClips[0]);
            gameController.StarHit = false;
        }

        if(gameController.CheckPointHit)
        {
            audioSource.PlayOneShot(gameController.audioClips[4]);
            gameController.CheckPointHit = false;
        }

    }


}
