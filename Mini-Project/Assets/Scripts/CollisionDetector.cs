using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    GameController gameController;

    void Start()
    {
        gameController = GameObject.Find("StarSpawner").GetComponent<GameController>();
    }
    void OnCollisionEnter(Collision collision)
    {
        //gameObject.SetActive(false);
        if(collision.gameObject.tag == "Sphere")
        {
            collision.gameObject.SetActive(false);
            collision.gameObject.transform.position = new Vector3(31.22647f, .55f, -31.16775f);
            collision.gameObject.SetActive(true);

            foreach (var Star in gameController.DeactivatedObjects)
            {
                Star.SetActive(true);
                
            }
            gameController.DeactivatedObjects.Clear();
        }
    }
}
