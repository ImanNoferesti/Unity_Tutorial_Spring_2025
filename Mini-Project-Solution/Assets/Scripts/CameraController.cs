using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    public GameObject Player;
    public Vector3 Offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x + Offset.x, Player.transform.position.y + Offset.y, Player.transform.position.z + Offset.z);
    }
}
