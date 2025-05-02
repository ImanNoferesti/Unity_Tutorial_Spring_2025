using UnityEngine;

public class Crusher : MonoBehaviour
{
    
    public float upwardForce;
    public float downwardForce;
    bool upward = true;
    public int yLimit;

    Rigidbody rb;

    AudioSource audioSource;
    GameController gameController;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;

        gameController = GameObject.Find("GameManager").GetComponent<GameController>();

        audioSource =gameObject.AddComponent<AudioSource>();
        audioSource.clip = gameController.audioClips[3];
        audioSource.playOnAwake = false;
        audioSource.loop = false;
    }

    void FixedUpdate()
    {
        if (upward)
        {
            rb.AddForce(Vector3.up * upwardForce, ForceMode.Force);
            rb.linearDamping += 0.08f;

            if (transform.position.y > yLimit)
            {
                upward = false;
                rb.linearDamping = 0f;
                rb.linearVelocity = Vector3.zero;
                rb.isKinematic = true;
            }
        }
    else
        {
            rb.isKinematic = false;
            rb.AddForce(Vector3.down * downwardForce, ForceMode.Force);

            if (transform.position.y < 2.5f)
            {
                audioSource.Play();
                upward = true;
            }
            
        }

    }

}
