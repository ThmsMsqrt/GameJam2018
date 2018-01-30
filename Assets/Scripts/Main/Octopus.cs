using ScriptableFramework.Variables;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Main
{
    public class Octopus : MonoBehaviour
    {
        public AnimatorManager OctopusStates;
        public FloatReference Score;
        public AudioManager AudioClips;
        private AudioSource _audio;

        private Animator AnimatorOctopus;
        private int OctopusStateStart = 0;
        private float evolveThreshold = 20.0f;
        
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
            Debug.Log(evolveThreshold);
            if (Score.Value >= evolveThreshold)
            {
                if (AnimatorOctopus != null)
                {
                    if(OctopusStateStart < OctopusStates.Animators.Length)
                    {
                        OctopusStateStart++;
                        AnimatorOctopus.runtimeAnimatorController = OctopusStates.Animators[OctopusStateStart];
                        
                        if (_audio != null)
                        {
                            _audio.PlayOneShot(AudioClips.SquidEvolveSound);
                        }
                        evolveThreshold += 20.0f;
                    }
                }
            }
        }
         
    }
}
