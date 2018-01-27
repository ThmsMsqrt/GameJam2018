using UnityEngine;

[CreateAssetMenu(menuName = "Manager/AudioManager")]
public class AudioManager : ScriptableObject
{
    public AudioClip BackgroundMusic;
    public AudioClip SquidClickSound;
    public AudioClip SquidEvolveSound;
    public AudioClip UpgradeClickSound;
    public AudioClip ItemClickSound;
}
