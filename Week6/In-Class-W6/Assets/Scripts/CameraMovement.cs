using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float playerSpeed;
    public float tireRotation;

    public float tireTurn;

    public float turnRate;

    public float MaxAngle;
    public float CurrentYAngle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (gameObject.tag == "Wheel")
        {
            CurrentYAngle = transform.parent.transform.localEulerAngles.y;
        }
        
    }

    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        
        if (gameObject.tag == "Truck")
        {
            transform.Translate(new Vector3(xInput, 0f, zInput)* playerSpeed * Time.deltaTime);
            transform.Rotate(new Vector3(0, xInput, 0) * turnRate * Time.deltaTime);
        }
        
        if (gameObject.tag == "Wheel")
        {
        //Rotation around X
            transform.Rotate(new Vector3 (zInput, 0f, 0f), tireRotation * Time.deltaTime);

        //Rotation around Y
            if (Mathf.Abs(CurrentYAngle + xInput * tireTurn * Time.deltaTime) <= MaxAngle)
            {
                transform.parent.transform.Rotate(new Vector3(0f, xInput, 0f), tireTurn * Time.deltaTime);
                CurrentYAngle += xInput * tireTurn * Time.deltaTime;
                
            }
        }
        if (gameObject.tag == "BackWheel")
        {
            transform.Rotate(new Vector3 (zInput, 0f, 0f), tireRotation * Time.deltaTime);
        }
    }

    // ******** INITIAL LOGIC *********
    // void Update()
    // {
    //     float xInput = Input.GetAxis("Horizontal");
    //     float zInput = Input.GetAxis("Vertical");
    //     if (gameObject.tag == "Truck")
    //     {
    //         transform.Translate(new Vector3(xInput, 0f, zInput)* playerSpeed * Time.deltaTime);
    //         transform.Rotate(new Vector3(0, xInput, 0) * turnRate * Time.deltaTime);
    //     }
        
    //     if (gameObject.tag == "BackWheel")
    //     {
    //         transform.Rotate(new Vector3(zInput, 0f, 0f), tireRotation * Time.deltaTime);
    //     }
    //     if (gameObject.tag == "Wheel")
    //     {
    //         transform.Rotate(new Vector3(zInput, 0f, 0f), tireRotation * Time.deltaTime);

    //         if (transform.parent.transform.localEulerAngles.y <= 30f || transform.parent.transform.localEulerAngles.y >= 330)
    //         {
    //             transform.parent.transform.Rotate(new Vector3(0f, xInput, 0f), tireTurn * Time.deltaTime);
    //         }
    //         else 
    //         {
    //             if (transform.parent.transform.localEulerAngles.y > 30f && transform.parent.transform.localEulerAngles.y <= 180f)
    //             {
    //                 transform.parent.transform.localEulerAngles = new Vector3(0f, 29.9f, 0f);
    //             }
                
            
    //             if (transform.parent.transform.localEulerAngles.y < 330f && transform.parent.transform.localEulerAngles.y > 180f)
    //             {
    //                 transform.parent.transform.localEulerAngles = new Vector3(0f, 330.1f, 0f);
    //             }
    //         }
    //     }
        
    //     //Debug.Log($"Forward: {Input.GetKey(KeyCode.W)}");
    // }
}
