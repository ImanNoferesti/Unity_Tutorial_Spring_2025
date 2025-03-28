using UnityEngine;

public class Rotator : MonoBehaviour
{

    // [SerializeField]private float RotationAngle;
    //[HideInInspector]public float RotationAngle;
    public float RotationAngle;
    public float FanSpeed;
    public float Angle;
    public float MovementSpeed;

    // void Start()
    // {
    //     RotationAngle = 3;
    // }

    // Update is called once per frame
    void Update()
    {   

        if(gameObject.tag == "Heli")
        {
            // Some actions
            transform.Rotate(Vector3.forward, RotationAngle * Time.deltaTime);
            transform.GetChild(2).transform.Rotate(Vector3.up, FanSpeed * Time.deltaTime);

            if(transform.position.y <= 10f)
            {
                transform.Translate(Vector3.up * MovementSpeed * Time.deltaTime);
            }
        }

        else
        {
            //Debug.Log($"EulerAngle: {transform.localEulerAngles}, Quaternion: {transform.localRotation}");
            // transform.Rotate(Vector3.forward, RotationAngle * Time.deltaTime);
            //transform.localEulerAngles += Vector3.forward * RotationAngle * Time.deltaTime;
            transform.localRotation *= Quaternion.Euler(Vector3.forward * RotationAngle * Time.deltaTime);

            transform.GetChild(0).transform.Rotate(Vector3.back, FanSpeed * Time.deltaTime);

            // transform.RotateAround(new Vector3(0f,0f,0f), Vector3.up, Angle * Time.deltaTime);
            transform.RotateAround(Vector3.zero, Vector3.up, Angle * Time.deltaTime);
        }
        
    }
}
