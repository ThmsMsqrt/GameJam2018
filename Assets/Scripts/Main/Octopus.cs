using ScriptableFramework.Variables;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Main
{
    public class Octopus : MonoBehaviour
    {
        public AnimatorManager OctopusStates;
        public FloatReference DPS;
        public AudioManager AudioClips;
        private AudioSource _audio;

        private Animator AnimatorOctopus;
        private int OctopusStateStart = 0;
        private float thresholdEvolve = 100f;

        public void Start()
        {
            _audio = GetComponent<AudioSource>();
            AnimatorOctopus = GetComponent<Animator>();
            if (AnimatorOctopus != null)
            {
                AnimatorOctopus.runtimeAnimatorController = OctopusStates.Animators[0];
            }
        }

        public void FixedUpdate()
        {
            if(DPS.Value > thresholdEvolve)
            {
                if (OctopusStateStart < OctopusStates.Animators.Length)
                {
                    if (AnimatorOctopus != null)
                    {
                        ++OctopusStateStart;
                        AnimatorOctopus.runtimeAnimatorController = OctopusStates.Animators[OctopusStateStart];
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
