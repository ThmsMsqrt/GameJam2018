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
}
