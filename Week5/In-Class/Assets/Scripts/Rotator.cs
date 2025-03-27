using UnityEngine;

public class Rotator : MonoBehaviour
{
   public float RotationAngle;
   public float FanSpeed;
   public float Angle;
   public float HelicopterFan;

    public float HelicopterUp;

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "Heli")
        {
            transform.GetChild(2).transform.Rotate(Vector3.down, HelicopterFan * Time.deltaTime);

            transform.localRotation *= Quaternion.Euler(Vector3.forward * RotationAngle * Time.deltaTime);

            if(transform.position.y <= 5)
            {
                transform.Translate(Vector3.up * HelicopterUp * Time.deltaTime);
            }
        }
        else
        {
            //transform.Rotate(Vector3.forward, RotationAngle * Time.deltaTime);
            //transform.localEulerAngles += Vector3.forward * RotationAngle * Time.deltaTime;
            transform.localRotation *= Quaternion.Euler(Vector3.forward * RotationAngle * Time.deltaTime);

            transform.GetChild(0).transform.Rotate(Vector3.back, FanSpeed * Time.deltaTime);

            transform.RotateAround(new Vector3(0,0,0), Vector3.up, Angle * Time.deltaTime);
        }
        

        
    }
}
