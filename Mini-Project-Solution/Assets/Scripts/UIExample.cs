using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIExample : MonoBehaviour
{
    public Button myButton;
    public TMP_Text myText;

    void Start()
    {
        myButton.onClick.AddListener(ChangeScenes);
        myText.text = "Press"; 
    }


    public void DisplayMessage()
    {
        Debug.Log("Button is pressed");
    
    }

    public void ChangeScenes()
    {
        SceneManager.LoadScene(1);
    }

}
