using System;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float RotationAngle;

    public float FanSpeed;

    public float RotationAroundSpeed;


    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(Vector3.forward, RotationAngle * Time.deltaTime); // Delta time is used to make the rotation frame-rate independent

        // transform.localEulerAngles += Vector3.forward * (RotationAngle * Time.deltaTime); // Rotate the object around its local forward axis

        transform.localRotation *= Quaternion.Euler(Vector3.forward * (RotationAngle * Time.deltaTime)); // Rotate the object using Quaternion for smoother rotation

        transform.GetChild(0).transform.Rotate(Vector3.back, FanSpeed * Time.deltaTime); // Rotate the child object (fan) at a different speed

        transform.RotateAround(Vector3.zero, Vector3.up, RotationAroundSpeed * Time.deltaTime); // Rotate around the origin (0,0,0) if needed
    }
}
