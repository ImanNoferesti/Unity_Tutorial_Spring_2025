using UnityEngine;

public class TriggerDetector : MonoBehaviour
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
            gameController.DeActivatedObjs.Add(gameObject);
            gameObject.SetActive(false);
        } 

        else if(other.tag == "Player" && gameObject.tag != "Checkpoint" && gameController.tag == "Level2")
        {
            gameController.DeActivatedObjs2.Add(gameObject);
            gameObject.SetActive(false);
        }

        else if(other.tag == "Player") 
        {
            gameObject.SetActive(false);
            other.gameObject.transform.position = new Vector3(-25f, 0.5f, -30f);
            gameController.tag = "Level2";
            other.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
            other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }       
    }
}

