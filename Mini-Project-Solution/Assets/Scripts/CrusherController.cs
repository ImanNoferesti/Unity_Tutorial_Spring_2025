using UnityEngine;

public class CrusherController : MonoBehaviour
{
    public float UpwardForce;
    public float DownForce;
    public int YLimit;
    bool upward = true;
    Rigidbody rb;

    GameController gameController;
    AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;

        gameController = GameObject.Find("GameManager").GetComponent<GameController>();

        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = gameController.audioClips[3];
        audioSource.playOnAwake = false;
        audioSource.loop = false;
    }

    void FixedUpdate()
    {
        if(upward)
        {
            rb.AddForce(Vector3.up * UpwardForce, ForceMode.Force);
            rb.linearDamping += 0.08f;

            if(transform.position.y > YLimit)
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
            rb.AddForce(Vector3.down * DownForce, ForceMode.Force);

            if(transform.position.y < 2.6f)
            {
                audioSource.Play();
                upward = true;
            }
        }



    }
}
