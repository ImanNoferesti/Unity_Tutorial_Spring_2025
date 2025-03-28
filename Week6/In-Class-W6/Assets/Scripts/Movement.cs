using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed; 
    public float RotationSpeed;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        if(gameObject.tag == "FrontWheels") 
        {
            transform.Rotate(new Vector3(verticalInput, 0f, 0f), Speed * Time.deltaTime);
            
            if(transform.localEulerAngles.y <= 30f || transform.localEulerAngles.y >= 330f) 
            {
                transform.Rotate(new Vector3(0f, horizontalInput, 0f), RotationSpeed * Time.deltaTime);
            }
            
            else
            {
                if(transform.localEulerAngles.y > 30f || transform.localEulerAngles.y <= 180f) 
                {
                    transform.localEulerAngles = new Vector3(0f, 30f, 0f);
                }
                if(transform.localEulerAngles.y > 180f || transform.localEulerAngles.y < 330f) 
                {
                    transform.localEulerAngles = new Vector3(0f, 330f, 0f);
                }
                
                
                //transform.Rotate(new Vector3(0f, -horizontalInput, 0f), RotationSpeed * Time.deltaTime);
            }
            
        }
        else
        {
            transform.Translate(new Vector3(0f,0f,verticalInput) * Speed * Time.deltaTime);
            transform.Rotate(new Vector3(0f, horizontalInput, 0f), RotationSpeed * Time.deltaTime);
        }
        

        

        
    }
}
