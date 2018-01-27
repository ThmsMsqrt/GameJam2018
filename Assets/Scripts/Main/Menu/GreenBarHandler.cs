using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenBarHandler : MonoBehaviour
{

    public Text ResumeText, BackToMenuText, QuitText;
    public GameObject MenuPanel;
    public ButtonHandler ButtonHandlerScript;

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
        if (rect.offsetMin.y < 76.8f)
        {
            rect.offsetMin = new Vector2(rect.offsetMin.x, rect.offsetMin.y + 76.8f);
            rect.offsetMax = new Vector2(rect.offsetMax.x, rect.offsetMax.y + 76.8f);
            indexCurrentButton--;
            ChangeColorText();
        }
    }

    public void OnGoingDown()
    {
        // offsetmin = new Vector2(left, bottom); 
        // offsetmax = new Vector2(-right, -top);
        if (rect.offsetMin.y > -76.8f)
        {
            rect.offsetMin = new Vector2(rect.offsetMin.x, rect.offsetMin.y - 76.8f);
            rect.offsetMax = new Vector2(rect.offsetMax.x, rect.offsetMax.y - 76.8f);
            indexCurrentButton++;
            ChangeColorText();
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
                MenuPanel.SetActive(false);
                break;
            case (1):
                ButtonHandlerScript.BackToMenu();
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
        ResumeText.color = green;
        BackToMenuText.color = green;
        QuitText.color = green;
        switch (indexCurrentButton)
        {
            case (0):
                ResumeText.color = black;
                break;
            case (1):
                BackToMenuText.color = black;
                break;
            case (2):
                QuitText.color = black;
                break;
            default:
                Debug.LogError("Error with INDEX CURRENT BUTTON / " + indexCurrentButton);
                break;
        }
    }
}
