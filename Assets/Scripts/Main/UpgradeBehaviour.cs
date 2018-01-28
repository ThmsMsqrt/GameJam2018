using ScriptableFramework.Variables;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeBehaviour : MonoBehaviour
{
    public Upgrade AttachedItem;
    public FloatReference Score;

    private Button _buyButton;

    private void Start()
    {
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
