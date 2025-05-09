using UnityEngine;

public class ObstacleControl : MonoBehaviour
{
    public float Speed;
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
        if (gameObject.tag == "Blade")
        {
            if(_right)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);

            if(transform.position.z + Vector3.forward.z * Time.deltaTime > _initialZPosition + ZLimit)
            {
                _right = false;
            }
        }

        else
        {
            transform.Translate(Vector3.back * Time.deltaTime * Speed);

            if(transform.position.z - Vector3.forward.z * Time.deltaTime < _initialZPosition)
            {
                _right = true;
            }
        }
        }
    }
}
