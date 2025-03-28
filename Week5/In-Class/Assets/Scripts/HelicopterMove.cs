using UnityEngine;

public class HelicopterMove : MonoBehaviour
{
    public float RotationAngle;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RotationAngle = RotationAngle + .25f;
        speed = RotationAngle / 500f;
        transform.GetChild(2).transform.Rotate(Vector3.up, RotationAngle * Time.deltaTime);
        if (speed > .5 && speed < 1)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (speed > 1)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
