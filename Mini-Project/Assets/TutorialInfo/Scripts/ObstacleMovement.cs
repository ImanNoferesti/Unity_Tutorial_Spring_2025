using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    
    public float speed;
    public float ZLimit;
    private float _initialZPosition;
    private bool _right = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _initialZPosition = transform.position.z; 
    }

    // Update is called once per frame
    void Update()
    {
        if(_right == true)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime); 

            if(transform.position.z + Vector3.forward.z * Time.deltaTime > _initialZPosition + ZLimit)
            {
                _right = false; 
            }
        }
        
        else
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime); 

            if(transform.position.z - Vector3.forward.z * Time.deltaTime < _initialZPosition)
            {
                _right = true; 
            }
        }
        
    }
}
