using UnityEngine;

public class Hierarchy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Started Cube 6");
        Debug.Log($"Root has {transform.root.childCount} childern");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
