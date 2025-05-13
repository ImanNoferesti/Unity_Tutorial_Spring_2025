using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    
    public InputActionAsset InputSystem;

    public GameObject prefab;

    public List<Color> colors;

    List<GameObject> clonedObjects = new List<GameObject>();

    InputAction moveAction;
    InputAction spawnAction;
    InputAction destroyAction;

    InputAction colorizeAction;
    
    public float  speed;

    void OnEnable()
    {
        InputSystem.Enable();
    }

    void OnDisable()
    {
        InputSystem.Disable();
    }


    void Start()
    {
        moveAction = InputSystem.FindActionMap("Player").FindAction("Move");
        spawnAction = InputSystem.FindActionMap("Player").FindAction("Spawn");
        destroyAction = InputSystem.FindActionMap("Player").FindAction("Destroy");
        colorizeAction = InputSystem.FindActionMap("Player").FindAction("Colorize");
    }


    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();

        transform.Translate(new Vector3(moveValue.x, 0, moveValue.y) * speed * Time.deltaTime);

        if(spawnAction.WasPressedThisFrame())
        {
            Debug.Log("Instantiate");
            int x = Random.Range(-10,10);
            int z = Random.Range(-10,10);
            Vector3 spawnPosition = new Vector3(x, 0, z);
            GameObject obj = Instantiate(prefab, spawnPosition, Quaternion.identity);
            clonedObjects.Add(obj);
        }

        if(destroyAction.WasPressedThisFrame())
        {
            Debug.Log("Destroy");

            Destroy(clonedObjects[0]);
            clonedObjects.RemoveAt(0);
        }

        if(colorizeAction.WasPressedThisFrame())
        {
            Debug.Log("Colorize");
            
            foreach (GameObject obj in clonedObjects)
            {
                int randomIndex = Random.Range(0, 5);
                obj.GetComponent<MeshRenderer>().material.color = colors[randomIndex];
            }
        }
    }
}
