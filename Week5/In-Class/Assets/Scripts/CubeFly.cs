using UnityEngine;

public class CubeFly : MonoBehaviour
{
    public float speed = 2f;
    public float fastSpeed = 10f;

    public int count = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        Debug.Log("Ominous noises...");
    }

    // Update is called once per frame
    void Update()
    {
        double zPos = transform.position.z;
        double yPos = transform.position.y;
        if (zPos < 5 && count ==0)
        {
            Debug.Log("ONE");
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (yPos > 1.5)
        {
            count = 1;
            Debug.Log("TWO");
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else if (zPos > -13)
        {
            Debug.Log("THREE");
            transform.Translate(Vector3.back * fastSpeed * Time.deltaTime);
        }
    }
}
