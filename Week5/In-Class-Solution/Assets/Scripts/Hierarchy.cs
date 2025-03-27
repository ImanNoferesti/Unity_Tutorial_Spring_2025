using UnityEngine;

public class Hierarchy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Root: {transform.root.name}");
        Debug.Log($"Deepest Parent: {transform.parent.name}");
        Debug.Log($"First Cube: {transform.root.Find("Cube (2)")}");
        Debug.Log($"Deepest Cube: {transform.root.Find("Cube (3)/Cube (5)/Cube (6)")}");
        Debug.Log($"Total Children: {transform.root.childCount}");
        Debug.Log($"Third Child: {transform.root.GetChild(2)}");
        Debug.Log($"Root index: {transform.root.GetSiblingIndex()}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
