using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    public GameObject Player;
    public Vector3 offset; 

    GameController gameController;

    void Start()
    {
        gameController = GameObject.Find("GameManager").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.tag == "Level1")
        {
            transform.position = new Vector3(Player.transform.position.x + offset.x, Player.transform.position.y + offset.y, Player.transform.position.z + offset.z); // Update the camera position based on the player's position and the offset
        }
        else
        {
            transform.eulerAngles = new Vector3(15f, -270f, 0f); // Rotate the camera to face the opposite direction
            transform.position = new Vector3(Player.transform.position.x - offset.x, Player.transform.position.y + offset.y, Player.transform.position.z - offset.z); // Update the camera position based on the player's position and the offset
        }
        
        
    }
}
