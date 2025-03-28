using UnityEngine;

public class TextMovement : MonoBehaviour
{
    public float speed = 2f;
    public int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count < 1000)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        

    }
}
