using UnityEngine;

public class CubeFly : MonoBehaviour
{
    public float speed = 2f;
    public float fastSpeed = 20f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        Debug.Log("Ominous noises...");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z < 5)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        
    }
}
