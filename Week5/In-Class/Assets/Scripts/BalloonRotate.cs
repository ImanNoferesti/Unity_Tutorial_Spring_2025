using UnityEngine;

public class BalloonRotate : MonoBehaviour
{
    public float SwarmSpeed;
    public float RotateSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Balloon")
        {
            transform.RotateAround(new Vector3(0,0,0), Vector3.up, SwarmSpeed * Time.deltaTime);
            transform.Rotate(Vector3.up, RotateSpeed * Time.deltaTime);
            //transform.localRotation();
        }
        
    }
}
