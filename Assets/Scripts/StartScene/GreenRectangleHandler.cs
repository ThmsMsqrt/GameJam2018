using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenRectangleHandler : MonoBehaviour {

    public Text StartText, CreditsText, QuitText;

    //6.172.29

    Color32 green;
    Color32 black;
    RectTransform rect;
    int indexCurrentButton = 0;

    private void Start()
    {
        green = new Color32(6, 172, 29, 255);
        black = Color.black;
        rect = GetComponent<RectTransform>();   
    }

    public void OnGoingUp()
    {
        // offsetmin = new Vector2(left, bottom); 
        // offsetmax = new Vector2(-right, -top);
        if (rect.offsetMin.y < 40.5f)
        {
            rect.offsetMin = new Vector2(rect.offsetMin.x, rect.offsetMin.y + 40.5f);
            rect.offsetMax = new Vector2(rect.offsetMax.x, rect.offsetMax.y + 40.5f);
            indexCurrentButton--;
            ChangeColorText();
        }
    }

    public void OnGoingDown()
    {
        // offsetmin = new Vector2(left, bottom); 
        // offsetmax = new Vector2(-right, -top);
        if (rect.offsetMin.y > - 40.5f)
        {
            rect.offsetMin = new Vector2(rect.offsetMin.x, rect.offsetMin.y - 40.5f);
            rect.offsetMax = new Vector2(rect.offsetMax.x, rect.offsetMax.y - 40.5f);
            indexCurrentButton++;
            ChangeColorText();
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
}
