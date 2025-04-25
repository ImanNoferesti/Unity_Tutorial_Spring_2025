using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.SetActive(false);
            collision.gameObject.transform.position = new Vector3(29f,0.6f,-24f);
            collision.gameObject.SetActive(true);
        }
        
    }

}
