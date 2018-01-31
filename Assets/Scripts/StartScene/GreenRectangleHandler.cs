using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenRectangleHandler : MonoBehaviour {

    public Text StartText, CreditsText, QuitText;
    public Sprite FirstBackground, SecondBackground, ThirdBackground;
    public GameObject BackgroundPanel;
    public ButtonHandler ButtonHandlerScript;
    public float ValueToMove;
        
    Color32 green;
    Color32 black;
    RectTransform rect;
    int indexCurrentButton = 0;

    private void Start()
    {
        green = new Color32(0, 255, 0, 255);
        black = Color.black;
        rect = GetComponent<RectTransform>();   
    }

    public void OnGoingUp()
    {
        // offsetmin = new Vector2(left, bottom); 
        // offsetmax = new Vector2(-right, -top);
        if (rect.offsetMin.y < 40.5f)
        {
            rect.offsetMin = new Vector2(rect.offsetMin.x, rect.offsetMin.y + ValueToMove);
            rect.offsetMax = new Vector2(rect.offsetMax.x, rect.offsetMax.y + ValueToMove);
            indexCurrentButton--;
            ChangeColorText();
            ChangeBackground();
        }
    }

    public void OnGoingDown()
    {
        // offsetmin = new Vector2(left, bottom); 
        // offsetmax = new Vector2(-right, -top);
        if (rect.offsetMin.y > - 40.5f)
        {
            rect.offsetMin = new Vector2(rect.offsetMin.x, rect.offsetMin.y - ValueToMove);
            rect.offsetMax = new Vector2(rect.offsetMax.x, rect.offsetMax.y - ValueToMove);
            indexCurrentButton++;
            ChangeColorText();
            ChangeBackground();
        }
    }

    /// <summary>
    /// Method to handle the enter key
    /// </summary>
    public void EnterClicked()
    {
        switch (indexCurrentButton)
        {
            case (0):
                ButtonHandlerScript.StartApp();
                break;
            case (1):
                ButtonHandlerScript.LoadGame();
                break;
            case (2):
                ButtonHandlerScript.QuitApp();
                break;
            default:
                Debug.LogError("Error with INDEX CURRENT BUTTON / " + indexCurrentButton);
                break;
        }
    }

    void ChangeColorText()
    {
        StartText.color = green;
        CreditsText.color = green;
        QuitText.color = green;
        switch (indexCurrentButton)
        {
            case (0):
                StartText.color = black;
                break;
            case (1):
                CreditsText.color = black;
                break;
            case (2):
                QuitText.color = black;
                break;
            default:
                Debug.LogError("Error with INDEX CURRENT BUTTON / " + indexCurrentButton);
                break;
        }
    }
    
    void ChangeBackground()
    {
        switch (indexCurrentButton)
        {
            case (0):
                BackgroundPanel.GetComponent<Image>().sprite = FirstBackground;
                break;
            case (1):
                BackgroundPanel.GetComponent<Image>().sprite = SecondBackground;
                break;
            case (2):
                BackgroundPanel.GetComponent<Image>().sprite = ThirdBackground;
                break;
            default:
                Debug.LogError("Error with INDEX CURRENT BUTTON / " + indexCurrentButton);
                break;
        }
    }
} 
