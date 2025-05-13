using UnityEngine;

public class CharacterController : MonoBehaviour
{

    private Animator animator;
    public float MovementSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(0f, 0f, verticalInput) * Time.deltaTime * MovementSpeed);

        if(verticalInput > 0f)
        {
            animator.SetBool("Walk", true);
        }
        else if(verticalInput == 0)
        {
            animator.SetBool("Walk", false);
            animator.SetBool("WalkBackwards", false);
        }
        else
        {
            animator.SetBool("WalkBackwards", true);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }
        else
        {
            animator.ResetTrigger("Jump");
        }
    }
}
