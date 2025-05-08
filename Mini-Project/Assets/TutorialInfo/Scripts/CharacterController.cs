using UnityEngine;
using UnityEngine.AI;

public class CharacterController : MonoBehaviour
{
    
    Animator animator;

    public float movementSpeed;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(0f,0f,verticalInput) * movementSpeed * Time.deltaTime);

        if(verticalInput > 0)
        {
            animator.SetBool("walk", true);
        }
        else if (verticalInput == 0)
        {
            animator.SetBool("walk", false);
            animator.SetBool("backwards", false);
        }
        else 
        {
            animator.SetBool("backwards", true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jump");
        }
        else
        {
            animator.ResetTrigger("jump");
        }

    }
}
