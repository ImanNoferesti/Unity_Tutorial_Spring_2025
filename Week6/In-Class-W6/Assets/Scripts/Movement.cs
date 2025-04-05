using UnityEngine;

public class Movement : MonoBehaviour
{   

    public float MovementSpeed;
    public float RotationAngle;

    public float MaxAngle;
    private float _currentYRotation;

    void Start()
    {
        if(gameObject.tag == "frontTire")
        {
            _currentYRotation = transform.parent.transform.localEulerAngles.y;
        }
    }

    void Update()
    {


        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");


        if(gameObject.tag == "frontTire")
        {
            transform.Rotate(new Vector3(verticalInput, 0f, 0f), MovementSpeed * Time.deltaTime); // for the rotation motion
            
            // Rotation around x-axis
            transform.Rotate(new Vector3(verticalInput, 0f, 0f), MovementSpeed * Time.deltaTime);

            // Rotation around y-axis
            if(Mathf.Abs(_currentYRotation + horizontalInput * RotationAngle * Time.deltaTime) <= MaxAngle)
            {
                Debug.Log($"horizontalInput: {horizontalInput}, currentY: {_currentYRotation}");
                transform.parent.transform.Rotate(new Vector3(0f, horizontalInput, 0f), RotationAngle * Time.deltaTime);
                _currentYRotation += horizontalInput * RotationAngle * Time.deltaTime;
            }
        }

        if(gameObject.tag == "frontTireL")
        {
            transform.Rotate(new Vector3(verticalInput, 0f, 0f), MovementSpeed * Time.deltaTime); // for the rotation motion
            
            // Rotation around x-axis
            transform.Rotate(new Vector3(verticalInput, 0f, 0f), MovementSpeed * Time.deltaTime);

            // Rotation around y-axis
            if(Mathf.Abs(_currentYRotation + horizontalInput * RotationAngle * Time.deltaTime) <= MaxAngle)
            {
                Debug.Log($"horizontalInput: {horizontalInput}, currentY: {_currentYRotation}");
                transform.parent.transform.Rotate(new Vector3(0f, horizontalInput, 0f), RotationAngle * Time.deltaTime);
                _currentYRotation += horizontalInput * RotationAngle * Time.deltaTime;
            }
        }

        if(gameObject.tag == "generalMotion")
        {
            transform.Translate(new Vector3 (0f, 0f, verticalInput) * MovementSpeed * Time.deltaTime);

            transform.Rotate(new Vector3(0f, horizontalInput, 0f), RotationAngle * Time.deltaTime);
        }

        if(gameObject.tag == "backTire")
        {
            transform.Rotate(new Vector3(verticalInput, 0f, 0f), MovementSpeed * Time.deltaTime); // for the rotation motion
        }
    }

}


// {
    
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
// }
