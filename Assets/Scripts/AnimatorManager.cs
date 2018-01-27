using ScriptableFramework.Variables;
using UnityEngine;

[CreateAssetMenu(menuName = "Manager/AnimatorManager")]
public class AnimatorManager : ScriptableObject
{
    public RuntimeAnimatorController[] Animators;
}
