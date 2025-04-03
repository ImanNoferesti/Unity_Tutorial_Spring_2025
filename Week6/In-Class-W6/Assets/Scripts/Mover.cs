using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TestTools.Utils;

public class Mover : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;
    public float MaxAngle;
    private float _currentYRotation;

    void Start()
    {
        _currentYRotation = transform.localEulerAngles.y;
    }

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Rotation around x-axis
        transform.Rotate(new Vector3(verticalInput, 0f, 0f), , MovementSpeed * Time.deltaTime);
        
        // Rotation around y-axis

        if(Mathf.Abs(_currentYRotation + verticalInput * RotationSpeed) <= MaxAngle)
        {
            transform.Rotate(new Vector3(0f, horizontalInput, 0f), RotationSpeed * Time.deltaTime);
            _currentYRotation = horizontalInput * RotationSpeed * Time.deltaTime;
        }
    }





    //////////////// initial logic - not great /////////////////

    // Update is called once per frame
    // void Update()
    // {
    //     float horizontalInput = Input.GetAxis("Horizontal");
    //     float verticalInput = Input.GetAxis("Vertical");

    //     if (gameObject.tag == "Frontwheel")
    //     {
    //         transform.Rotate(new Vector3(verticalInput, 0f, 0f), MovementSpeed * Time.deltaTime);

    //         // If rotating inside the boundary
    //         if(transform.parent.transform.localEulerAngles.y <= 30f || transform.localEulerAngles.y >= 330f)
    //         {
    //             transform.parent.transform.Rotate(new Vector3(0f, horizontalInput, 0f), RotationSpeed * Time.deltaTime);
    //         }

    //         // Outside the boundary
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

    // else
    // {
    //     transform.Translate(new Vector3(0f, 0f, verticalInput) * MovementSpeed * Time.deltaTime);
    //     transform.Rotate(new Vector3(0f,horizontalInput, 0f), RotationSpeed * Time.deltaTime);


    //     // Debug.Log($"vertical: {verticalInput}");
    // }



}

