using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        //gameObject.SetActive(false);
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.SetActive(false);
        }
        
    }

    // void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log(other.gameObject.name);
    // }
}
