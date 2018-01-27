using ScriptableFramework.Variables;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Main
{
    public class Octopus : MonoBehaviour
    {
        public SpriteManager OctopusStates;
        public FloatReference Score;

        private Image ImageOctopus;
        private int OctopusStateStart = 0;

        public void Start()
        {
            ImageOctopus = GetComponent<Image>();
            if (ImageOctopus != null)
            {
                ImageOctopus.sprite = OctopusStates.Sprites[0];
            }
        }

        public void Update()
        {
            if(Score.Value > 10)
            {
                if (OctopusStateStart < OctopusStates.Sprites.Length)
                {
                    if (ImageOctopus != null)
                    {
                        ImageOctopus.sprite = OctopusStates.Sprites[OctopusStateStart];
                        ++OctopusStateStart;
                    }
                }
            }
        }
         
    }
}
