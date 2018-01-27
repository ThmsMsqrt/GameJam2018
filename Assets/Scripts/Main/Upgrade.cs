using ScriptableFramework.Events;
using ScriptableFramework.Variables;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Upgrade")]
public class Upgrade : ScriptableObject
{
    public bool IsUnlocked;
    public string Name;
    public string Description;
    public string FluffText;
    public Sprite Sprite;
    [Range(0.0f, 1.0f)]
    public float AlphaColor;
    public float Cost;
    public float Multiplier;

    public Item UpgradableItem;
    public FloatVariable Score;
    public GameEvent CanBuyEvent;

    public void Buy()
    {
        if(UpgradableItem != null)
        {
            Score.Value -= Cost;
            UpgradableItem.UpdateUpgradeChain();
        }
    }

    public void CanBuy()
    {
        if (Score.Value >= Cost)
        {
            CanBuyEvent.Raise();
        }
    }
}
