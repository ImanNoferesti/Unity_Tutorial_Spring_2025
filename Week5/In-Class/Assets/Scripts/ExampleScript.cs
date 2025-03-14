using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello, I've started."); 
        Debug.Log($"{transform.root.childCount}"); 
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
