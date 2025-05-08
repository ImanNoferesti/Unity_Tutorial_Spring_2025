using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    GameController gameController;
    AudioSource audioSource;
    void Start()
    {
        gameController = GameObject.Find("GameManager").GetComponent<GameController>();
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = gameController.audioClips[2];
        audioSource.playOnAwake = false;
        audioSource.loop = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && gameController.tag == "Level1")
        {
            collision.gameObject.SetActive(false);
            collision.gameObject.transform.position = new Vector3(29f,0.6f,-24f);
            collision.gameObject.SetActive(true);

            foreach(var Star in gameController.DeActivatedObjs)
            {
                Star.SetActive(true);
            }

            gameController.DeActivatedObjs.Clear();
            audioSource.Play();
        }

        else if(collision.gameObject.tag == "Player" && gameController.tag == "Level2")
        {
            collision.gameObject.SetActive(false);
            collision.gameObject.transform.position = new Vector3(-25f, 0.5f, -30f);
            collision.gameObject.SetActive(true);

            foreach(var Star in gameController.DeActivatedObjs2)
            {
                Star.SetActive(true);
            }

            gameController.DeActivatedObjs2.Clear();
            audioSource.Play();
        }
    }
}
