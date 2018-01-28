using ScriptableFramework.Variables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MousePositionChecker : MonoBehaviour
{
    public GameObjectReference InfoPanel;
    public ScriptableObject ObjectBelow;

    public BoolVariable IsItem;

    public void DisplayInfoPanel()
    {
        if (ObjectBelow is Item)
        {
            DisplayItemTexts();
            IsItem.SetValue(true);
        }
        else if (ObjectBelow is Upgrade)
        {
            DisplayUpgradeTexts();
            IsItem.SetValue(false);
        }
        
        InfoPanel.Value.SetActive(true);
    }

    public void HideInfoPanel()
    {
        InfoPanel.Value.SetActive(false);
    }

    void DisplayItemTexts()
    {
        Text[] texts = InfoPanel.Value.GetComponentsInChildren<Text>();
        Item item = (Item)ObjectBelow;
        foreach (Text text in texts)
        {
            switch (text.gameObject.name)
            {
                case ("NameText"):
                    text.text = item.Name + " x " + item.NbItems;
                    break;
                case ("DescriptionText"):
                    text.text = item.Description;
                    break;
                case ("ActualPriceText"):
                    text.text = "Price : " + item.Cost.ToString();
                    break;
                default:
                    Debug.LogError("There's been a problem : " + text.gameObject.name);
                    break;
            }
        }
    }

    void DisplayUpgradeTexts()
    {
        Text[] texts = InfoPanel.Value.GetComponentsInChildren<Text>();
        Upgrade upgrade = (Upgrade)ObjectBelow;
        foreach (Text text in texts)
        {
            switch (text.gameObject.name)
            {
                case ("NameText"):
                    text.text = upgrade.Name;
                    break;
                case ("DescriptionText"):
                    text.text = upgrade.Description;
                    break;
                case ("ActualPriceText"):
                    text.text = "Price : " + upgrade.Cost.ToString();
                    break;
                default:
                    Debug.LogError("There's been a problem : " + text.gameObject.name);
                    break;
            }
        }
    }
}
