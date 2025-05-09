using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    GameController gameController;

    PlayerMovement sphere;
    PlayerMovement cameraMove;
    public Rigidbody sphereBody;
    public GameObject camera;

    void Start()
    {
        sphere = GameObject.Find("Sphere").GetComponent<PlayerMovement>();
        gameController = GameObject.Find("StarSpawner").GetComponent<GameController>();
        cameraMove = GameObject.Find("Camera").GetComponent<PlayerMovement>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sphere" && gameObject.tag != "Checkpoint")
        {
            gameController.DeactivatedObjects.Add(gameObject);
            Debug.Log(gameController.DeactivatedObjects.Count);
            gameObject.SetActive(false);
        }
        if (other.tag == "Sphere" && gameObject.tag == "Checkpoint")
        {
            gameObject.SetActive(false);
            sphereBody.linearVelocity = Vector3.zero;
            sphereBody.angularVelocity = Vector3.zero;
            other.gameObject.transform.position = new Vector3 (-30f, 1f, -24f);
            //other.gameObject.transform.Rotate(Vector3.up, 90f, Space.World);
            
            sphere.PlayerForce = sphere.PlayerForce * -1;
            cameraMove.levelTwo = true;
            camera.transform.RotateAround(other.gameObject.transform.position, Vector3.up, 180f);
        }
    }
}
