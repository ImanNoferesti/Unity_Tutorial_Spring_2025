using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    
    GameController gameController;

    void Start()
    {
        gameController = GameObject.Find("GameManager").GetComponent<GameController>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && gameController.tag == "Level1")
        {
            collision.gameObject.SetActive(false);
            collision.gameObject.transform.position = new Vector3(29f,0.6f,-24f);
            collision.gameObject.SetActive(true);

            foreach(var Star in gameController.DeactivatedObjs)
            {
                Star.SetActive(true);
            }

            gameController.DeactivatedObjs.Clear();
        }

        else if(collision.gameObject.tag == "Player" && gameController.tag == "Level2")
        {
            collision.gameObject.SetActive(false);
            collision.gameObject.transform.position = new Vector3(-25f,0.6f,-30f);
            collision.gameObject.SetActive(true);

            foreach(var Star in gameController.DeactivatedObjs2)
            {
                Star.SetActive(true);
            }

            gameController.DeactivatedObjs2.Clear();
        }
        
    }

}
