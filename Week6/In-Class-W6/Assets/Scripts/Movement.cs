using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed; 
    public float RotationSpeed;

    public float MaxAngle;
    private float _currentYRotation;

    void start() 
    {
        _currentYRotation = transform.parent.transform.localEulerAngles.y;
    }

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        if(gameObject.tag == "FrontWheels")
        {
            // Rotation around x-axis
            transform.Rotate(new Vector3(verticalInput, 0f, 0f), Speed * Time.deltaTime);

            //Rotation around y-axis
            if(Mathf.Abs(_currentYRotation + horizontalInput * RotationSpeed) <= MaxAngle)
            {
                transform.parent.transform.Rotate(new Vector3(0f, horizontalInput, 0f), RotationSpeed * Time.deltaTime);
                _currentYRotation += horizontalInput * RotationSpeed * Time.deltaTime;
            }
        }
    }

    ////////////////////////////////////////////////// Initial logic ///////////////////////////////////////////////////////
    // Update is called once per frame
    // void Update()
    // {
    //     float horizontalInput = Input.GetAxis("Horizontal");
    //     float verticalInput = Input.GetAxis("Vertical");
        
    //     if(gameObject.tag == "FrontWheels") 
    //     {
    //         transform.Rotate(new Vector3(verticalInput, 0f, 0f), Speed * Time.deltaTime);
            
    //         if(transform.parent.transform.localEulerAngles.y <= 30f || transform.parent.transform.localEulerAngles.y >= 330f) 
    //         {
    //             transform.parent.transform.Rotate(new Vector3(0f, horizontalInput, 0f), RotationSpeed * Time.deltaTime);
    //         }
            
    //         else
    //         {
    //             if(transform.parent.transform.localEulerAngles.y > 30f && transform.parent.transform.localEulerAngles.y <= 180f) 
    //             {
    //                 transform.parent.transform.localEulerAngles = new Vector3(0f, 29.9f, 0f);
    //             }
    //             if(transform.parent.transform.localEulerAngles.y > 180f && transform.parent.transform.localEulerAngles.y < 330f) 
    //             {
    //                 transform.parent.transform.localEulerAngles = new Vector3(0f, 330f, 0f);
    //             }
                
                
    //             //transform.Rotate(new Vector3(0f, -horizontalInput, 0f), RotationSpeed * Time.deltaTime);
    //         }
            
    //     }
        
    //     else
    //     {
    //         transform.Translate(new Vector3(0f,0f,verticalInput) * Speed * Time.deltaTime);
    //         transform.Rotate(new Vector3(0f, horizontalInput, 0f), RotationSpeed * Time.deltaTime);
    //     }
    // }


}
