
using UnityEngine;

public class airplanebehavior : MonoBehaviour
{
    //[HideInInspector]public float RotationAngle
    // 
    public float RotationAngle;
    public float FanSpeed;
    public float Angle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
    //     RotationAngle = 3
    // }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.forward, RotationAngle * Time.deltaTime);
        // transform.localEulerAngles += Vector3.forward * RotationAngle * Time.deltaTime;
        transform.localRotation *= Quaternion.Euler(Vector3.forward * RotationAngle * Time.deltaTime);
        transform.GetChild(0).transform.Rotate(Vector3.back, FanSpeed * Time.deltaTime);
        transform.RotateAround(Vector3.zero, Vector3.up, Angle * Time.deltaTime);

    }
}
