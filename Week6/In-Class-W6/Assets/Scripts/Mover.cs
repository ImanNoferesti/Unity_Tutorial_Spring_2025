using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;

  

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (gameObject.tag == "FrontWheel")
        {
            transform.Rotate(new Vector3(verticalInput,0f,0f), MovementSpeed * Time.deltaTime);
            transform.Rotate(new Vector3(0f,horizontalInput, 0f), RotationSpeed * Time.deltaTime);
        }
     
        else
        {
            transform.Translate(new Vector3(0f, 0f, verticalInput) * MovementSpeed * Time.deltaTime);
            transform.Rotate(new Vector3(0f,horizontalInput, 0f), RotationSpeed * Time.deltaTime);


            // Debug.Log($"vertical: {verticalInput}");
        }
       


    }
}
