using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float playerSpeed;
    public float tireRotation;

    public float tireTurn;

    public float turnRate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
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
            transform.Rotate(new Vector3(zInput, 0f, 0f), tireRotation * Time.deltaTime);
            
            if (transform.localEulerAngles.y <= 30f || transform.localEulerAngles.y >= 330)
            {
                transform.Rotate(new Vector3(0f, xInput, 0f), tireTurn * Time.deltaTime);
            }
            else 
            {
                if (transform.localEulerAngles.y > 30f && transform.localEulerAngles.y <= 180f)
                {
                    transform.localEulerAngles = new Vector3(0f, 30f, 0f);
                }
                
            
                if (transform.localEulerAngles.y < 330f && transform.localEulerAngles.y > 180f)
                {
                    transform.localEulerAngles = new Vector3(0f, 330f, 0f);
                }
            }
        }
        
        //Debug.Log($"Forward: {Input.GetKey(KeyCode.W)}");
    }
}
