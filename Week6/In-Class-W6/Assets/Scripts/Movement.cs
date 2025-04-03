using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    public float MaxAngle;
    private float _current
    
    //////////////////////////////////////////// INITIAL LOGIC //////////////////////////////////
    // // Update is called once per frame
    // void Update()
    // {
    //     float horizontalInput = Input.GetAxis("Horizontal");
    //     float verticalInput = Input.GetAxis("Vertical");

        
    //     if(gameObject.tag == "frontTire")
    //     {
    //         transform.Rotate(new Vector3(verticalInput, 0f, 0f), speed * Time.deltaTime); // for the motion

    //         // if rotating inside the boundary
    //         if(transform.parent.transform.localEulerAngles.y <= 30f || transform.localEulerAngles.y >= 330f)
    //         {
    //             transform.parent.transform.Rotate(new Vector3(0f, horizontalInput, 0f), rotationSpeed * Time.deltaTime);
    //         }

    //         else
    //         {
    //             if(transform.parent.transform.localEulerAngles.y > 30f && transform.localEulerAngles.y <= 180f)
    //             {
    //                 transform.parent.transform.localEulerAngles = new Vector3(0f, 29.9f, 0f);
    //             }
                
    //             if(transform.parent.transform.localEulerAngles.y > 180f && transform.localEulerAngles.y < 330f)
    //             {
    //                 transform.parent.transform.localEulerAngles = new Vector3(0f, 330f, 0f);
    //             }
    //         }


    //     }

    //      else
    //     {

    //      transform.Translate(new Vector3 (0f, 0f, verticalInput) * speed * Time.deltaTime);

    //      transform.Rotate(new Vector3(0f, horizontalInput, 0f), rotationSpeed * Time.deltaTime);
    //     } 
        


    // }
}
