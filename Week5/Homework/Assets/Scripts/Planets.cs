using UnityEngine;

public class Planets : MonoBehaviour
{

    public float RotateAngleFlankers;

    public float RotateAngleCenter;

    public float RotateAngleOddball;

    public float RotateAngleTop;
    public float MovementSpeed;

    public int count;

    Vector3 Scale;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Scale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (gameObject.tag == "CenterPlanet")
        {
            transform.Rotate(Vector3.right, RotateAngleCenter * Time.deltaTime);
        }
        if (gameObject.tag == "FlankerPlanets")
        {
            transform.Rotate(Vector3.forward, RotateAngleFlankers * Time.deltaTime);
        }
        if (gameObject.tag == "Oddball")
        {
            transform.parent.transform.Rotate(Vector3.forward, RotateAngleOddball * Time.deltaTime);
            if (count % 300 > 150)
            {
                transform.Translate(new Vector3(1, 1, 0) * MovementSpeed * Time.deltaTime);
            }
            else transform.Translate(new Vector3(-1, -1, 0) * MovementSpeed * Time.deltaTime);
            
        }
        if (gameObject.tag == "TopBottomPlanets")
        {
            Debug.Log(transform.parent.transform.localEulerAngles);
            if (transform.parent.transform.localEulerAngles.x <= 180f)
            {
                //transform.Translate(Vector3.forward * MovementSpeed * 10 * Time.deltaTime);
                Scale.x = Scale.x - .01f;
                Scale.y = Scale.y - .01f;
                Scale.z = Scale.z - .01f;
                Debug.Log($"Scale X: {Scale.x} Scale Y: {Scale.y} Scale Z: {Scale.z}");
                transform.localScale = Scale;
            }
            else    
            {
                Scale.x = Scale.x + .01f;
                Scale.y = Scale.y + .01f;
                Scale.z = Scale.z + .01f;
                transform.localScale = Scale;
            }
            
            //transform.Translate(Vector3.back * MovementSpeed * 10 * Time.deltaTime);
        }
            
        
    }
}
