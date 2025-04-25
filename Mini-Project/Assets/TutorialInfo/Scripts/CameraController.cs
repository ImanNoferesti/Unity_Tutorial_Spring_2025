using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    public GameObject Player;
    public Vector3 offset; 

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x + offset.x, Player.transform.position.y + offset.y, Player.transform.position.z + offset.z); // Update the camera position based on the player's position and the offset
    }
}
