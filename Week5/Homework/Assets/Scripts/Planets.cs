using UnityEngine;

public class Planets : MonoBehaviour
{

    public float RotateAngleFlankers;

    public float RotateAngleCenter;

    public float RotateAngleOddball;

    public float RotateAngleTop;
    public float MovementSpeed;

    public int count;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
            if (count < 125)
            {
                transform.RotateAround(new Vector3(4, 0 ,0), Vector3.forward, RotateAngleOddball * Time.deltaTime);
                count++;
                Debug.Log(count);
            }
            else if (count >= 125 && count < 250)
            {
                transform.RotateAround(new Vector3(0, 4, 0), Vector3.forward, RotateAngleOddball * Time.deltaTime);
                count++;
                Debug.Log(count);
            }
            else if (count >= 325 && count <525)
            {
                transform.RotateAround(new Vector3(-4, 0, 0), Vector3.forward, RotateAngleOddball * Time.deltaTime);
                count++;
                Debug.Log(count);
            }
            else if (count >= 525 && count <725)
            {
                transform.RotateAround(new Vector3(0, -4, 0), Vector3.forward, RotateAngleOddball * Time.deltaTime);
                count++;
                Debug.Log(count);
            }
            else if (count == 725)
            {
                count = 0;
            }
            
        }
    }
}
