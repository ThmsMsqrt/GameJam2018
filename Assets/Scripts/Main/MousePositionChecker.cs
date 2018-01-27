using ScriptableFramework.Variables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MousePositionChecker : MonoBehaviour
{
    public GameObjectReference InfoPanel;
    public ScriptableObject ObjectBelow;

    Ray ray;
    RaycastHit hit;

    public void DisplayInfoPanel()
    {
        Debug.Log(gameObject);
        InfoPanel.Value.SetActive(true);
    }

    public void HideInfoPanel()
    {
        Debug.Log(gameObject);
        InfoPanel.Value.SetActive(false);
    }
}
