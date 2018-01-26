using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Upgrade")]
public class Upgrade : ScriptableObject
{
    public bool IsUnlocked;
    public string Name;
    public string Description;
    public string FluffText;
    public Sprite Sprite;
    public float AlphaColor;
    public float Cost;
}
