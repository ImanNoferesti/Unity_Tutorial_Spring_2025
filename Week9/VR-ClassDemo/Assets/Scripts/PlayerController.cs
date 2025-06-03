using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public InputActionAsset InputSystem;
    public GameObject prefab;

    public Color[] colors;

    List<GameObject> clonedObj = new List<GameObject>();

    InputAction moveAction;
    InputAction spawnAction;
    InputAction destroyAction;
    InputAction colorizeAction;
    public float Speed;

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

        transform.Translate(new Vector3(moveValue.x, 0f, moveValue.y) * Time.deltaTime * Speed);


        if(spawnAction.WasPressedThisFrame())
        {
            Debug.Log("Instantiate");
            int x = Random.Range(1,5);
            int z = Random.Range(1,5);
            GameObject obj = Instantiate(prefab, new Vector3(x, 0f, z), Quaternion.identity);
            clonedObj.Add(obj);
        }

        if(destroyAction.WasPressedThisFrame() && clonedObj.Count >= 1)
        {
            Debug.Log("Destroy");
            Destroy(clonedObj[0]);
            clonedObj.RemoveAt(0);
        }

        if(colorizeAction.WasPressedThisFrame())
        {
            foreach(var obj in clonedObj)
            {
                int randIndex = Random.Range(0,5);
                obj.GetComponent<MeshRenderer>().material.color = colors[randIndex];
            }
        }
    }
}
