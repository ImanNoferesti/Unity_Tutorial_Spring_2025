using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    public GameObject Player;
    public Vector3 Offset;

    GameController gameController;
    void Start()
    {
        gameController = GameObject.Find("GameManager").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameController.tag == "Level1")
        {
            transform.position = new Vector3(Player.transform.position.x + Offset.x, Player.transform.position.y + Offset.y, Player.transform.position.z + Offset.z);
        }

        else if(gameController.tag == "Level2")
        {
            transform.eulerAngles = new Vector3(15f, -270f, 0f);
            transform.position = new Vector3(Player.transform.position.x - Offset.x, Player.transform.position.y + Offset.y, Player.transform.position.z - Offset.z);
        }
    }
}
