using ScriptableFramework.Variables;
using UnityEngine;
using UnityEngine.UI;

public class ItemBehaviour : MonoBehaviour
{
    public Item AttachedItem;
    public FloatReference Score;
    public FloatReference UnlockableItemPercentage;
    private Button _buyButton;
        
    private void Start()
    {
		AttachedItem.Cost = AttachedItem.BasePrice;
		AttachedItem.NbItems = 0;

        _buyButton = GetComponent<Button>();
    }

    void FixedUpdate()
    {
        CanBuy();
    }

    public void CanBuy()
    {
        if (Score.Value >= AttachedItem.Cost)
        {
            if (!_buyButton.interactable)
                _buyButton.interactable = true;
        }
        else
        {
            if (_buyButton.interactable)
                _buyButton.interactable = false;
        }
    }
}
