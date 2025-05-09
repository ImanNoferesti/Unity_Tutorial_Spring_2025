using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Add this line to include the SceneManager namespace

public class UIExample : MonoBehaviour
{
    

    public Button myButton;
    public TMP_Text myText;

    void Start()
    {
        myButton.onClick.AddListener(ChangeScene);
        myText.text = "Press";
    }


    // public void DisplayMessage()
    // {
    //     Debug.Log("Button is pressed!");
    // }

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }

}
