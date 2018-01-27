using ScriptableFramework.Events;
using ScriptableFramework.Variables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Item")]
public class Item : ScriptableObject
{

    private int _numberUpgradeDone;

	public string Name; //Object Name
    public string Description; // Correct description
	public string StupidQuote;

	public Sprite Image;
    
	public int NbItems;
	public float BasePrice = 0; //Price of the 1st one
    public float Cost; // Current price for one more
    public float BaseMultiplier = 1.15f; // 
    
	public bool IsUnlocked;
    
	public float DPSBase = 0;
	public float DPSMultiplier = 0;
    public FloatVariable DPS;
    public FloatVariable Score;

    public Upgrade[] UpgradeChain;
    public Item UnlockableItem;

    //TODO add IsUnlocked
    public void Buy()
    {
        if(Score.Value >= Cost)
        {
            Score.Value -= Cost;
            UpdatePrice();
            UpdateDPS();
        }
    }

    /// <summary>
    /// Calculate the new price of an object, based on a Super-Duper-Mega-Cool equation
    /// </summary>
    public void UpdatePrice()
    {
        float soldItemsFactor = Mathf.Pow(NbItems, BaseMultiplier);
        Cost = Mathf.Ceil(BasePrice * soldItemsFactor);
        NbItems += 1;
        if(NbItems == 1)
        {
            UnlockNextItem();
        }
    }

    public void UpdateUpgradeChain()
    {
        if(!(_numberUpgradeDone > UpgradeChain.Length))
        {
            BaseMultiplier *= UpgradeChain[_numberUpgradeDone].Multiplier;
            UpdateDPS();
            ++_numberUpgradeDone;
        }
    }
    
    private void UpdateDPS()
    {
        DPS.Value += (BaseMultiplier * NbItems);
    }

    public void UnlockNextItem()
    {
		if(!UnlockableItem.IsUnlocked && UnlockableItem != null)
        {
            UnlockableItem.IsUnlocked = true;

        }
    }
}