using ScriptableFramework.Variables;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Main
{
    public class Octopus : MonoBehaviour
    {
        public SpriteManager OctopusStates;
        public FloatReference DPS;
        public AudioManager AudioClips;
        private AudioSource _audio;

        private Image ImageOctopus;
        private int OctopusStateStart = 0;
        private float thresholdEvolve = 100f;

        public void Start()
        {
            _audio = GetComponent<AudioSource>();
            ImageOctopus = GetComponent<Image>();
            if (ImageOctopus != null)
            {
                ImageOctopus.sprite = OctopusStates.Sprites[0];
            }
        }

        public void FixedUpdate()
        {
            if(DPS.Value > thresholdEvolve)
            {
                if (OctopusStateStart < OctopusStates.Sprites.Length)
                {
                    if (ImageOctopus != null)
                    {
                        ++OctopusStateStart;
                        ImageOctopus.sprite = OctopusStates.Sprites[OctopusStateStart];
                        if (_audio != null)
                        {
                            _audio.PlayOneShot(AudioClips.SquidEvolveSound);
                        }
                        thresholdEvolve = 200f;
                    }
                }
            }
        }
         
    }
}
