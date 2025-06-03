using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public Button myButton;
    public TMP_Text myText;
    private int _clickCount;


    void Start()
    {
        myButton.onClick.AddListener(ButtonClick);
        

    }
    public void ButtonClick()
    {
        _clickCount++;
        Debug.Log("Button is pressed");
        myText.text = "Don't do that";
        if (_clickCount == 2)
        {
            myText.text = "stoooop";
        }
        if (_clickCount > 3)
        {
            SceneManager.LoadScene(1);
        }

    }

}
