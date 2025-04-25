using UnityEngine;

public class TriggerDetector : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameObject.SetActive(false);
        }        
    }
}

