using UnityEngine;

public class Lights : MonoBehaviour
{
    public float lightCount;
    public Light thisLight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
        lightCount++;

        if (gameObject.tag == "BlueLight")
        {
            if (lightCount % 100 >= 50)
            {
                thisLight.intensity = 0;
            }
            else thisLight.intensity = 20;
        }

        if (gameObject.tag == "RedLight")
        {
            if (lightCount % 100 < 50)
            {
                thisLight.intensity = 0;
            }
            else thisLight.intensity = 20;
        }
    }
}
