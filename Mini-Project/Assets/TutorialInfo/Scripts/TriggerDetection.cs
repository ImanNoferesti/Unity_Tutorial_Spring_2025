using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    
    GameController gameController;




    void Start()
    {
        gameController = GameObject.Find("GameManager").GetComponent<GameController>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && gameObject.tag != "Checkpoint" && gameController.tag == "Level1")
        {

            gameController.DeactivatedObjs.Add(other.gameObject);
            gameObject.SetActive(false);
            gameController.StarHit = true;
            
        }
        else if(other.tag == "Player" && gameObject.tag != "Checkpoint" && gameController.tag == "Level2")
        {
            
            gameController.DeactivatedObjs2.Add(other.gameObject);
            gameObject.SetActive(false);
            gameController.StarHit = true;
            
        }
        else if(other.tag == "Player")
        {
            
            gameObject.SetActive(false);
            other.gameObject.transform.position = new Vector3(-25f,0.6f,-30f);
            gameController.tag = "Level2";

            other.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
            other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

            gameController.CheckpointHit = true;
        }

    }
}
