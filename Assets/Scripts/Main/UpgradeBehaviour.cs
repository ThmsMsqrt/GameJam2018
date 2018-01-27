using UnityEngine;
using UnityEngine.UI;

public class UpgradeBehaviour : MonoBehaviour
{
    public Upgrade AttachedItem;

    private Button _buyButton;

    private void Start()
    {
        _buyButton = GetComponent<Button>();
    }

    public void CanBuy()
    {
        if (AttachedItem.Score.Value >= AttachedItem.Cost)
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

    void FixedUpdate()
    {
        CanBuy();
    }
}
