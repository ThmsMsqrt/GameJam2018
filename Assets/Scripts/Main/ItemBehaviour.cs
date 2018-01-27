using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Main
{
    public class ItemBehaviour : MonoBehaviour
    {
        public Item AttachedItem;

        private Button _buyButton;
        
        private void Start()
        {
            _buyButton = GetComponent<Button>();
        }
        
        public void CanBuy()
        {
            if (AttachedItem.Score.Value >= AttachedItem.CurrentPrice)
            {
                if(!_buyButton.interactable)
                    _buyButton.interactable = true;
            }
            else
            {
                if (_buyButton.interactable)
                    _buyButton.interactable = false;
            }
        }

        void FixedUpdate()
        {
            CanBuy();
        }
    }
}
