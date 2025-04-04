using UnityEngine;

public class Mover : MonoBehaviour
{   

    public float MovementSpeed;
    public float RotationAngle;

    public float MaxAngle;
    private float _currentYRotation;

    void Start()
    {
        if(gameObject.tag == "Frontwheel")
        {
            _currentYRotation = transform.parent.transform.localEulerAngles.y;
        }
    }

    void Update()
    {


        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        if(gameObject.tag == "Frontwheel")
        {
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

         if(gameObject.tag == "Backwheel")
         {
            transform.Rotate(new Vector3(verticalInput, 0f, 0f), MovementSpeed * Time.deltaTime);
         }
   

        if(gameObject.tag == "Main")
        {
            transform.Translate(new Vector3(0f, 0f, verticalInput) * MovementSpeed * Time.deltaTime);
            Debug.Log($"Vertical: {verticalInput}");
            transform.Rotate(new Vector3(0f, horizontalInput, 0f), RotationAngle * Time.deltaTime);
        }

     }

    ///////////////////////////////////////// Initial Logic ////////////////////////////////////////////////



    // Update is called once per frame
    // void Update()    {
    //     float horizontalInput = Input.GetAxis("Horizontal");
    //     float verticalInput = Input.GetAxis("Vertical");


    //     if(gameObject.tag == "Frontwheel")
    //     {
    //         transform.Rotate(new Vector3(verticalInput, 0f, 0f), MovementSpeed * Time.deltaTime);

    //         // If rotating inside the boundary
    //         if(transform.parent.transform.localEulerAngles.y <= 30f || transform.parent.transform.localEulerAngles.y >= 330f)
    //         {
    //             transform.parent.transform.Rotate(new Vector3(0f, horizontalInput, 0f), RotationSpeed * Time.deltaTime);
    //         }

    //         // Outside the boundary
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
    //         }



    //     }

   



}

