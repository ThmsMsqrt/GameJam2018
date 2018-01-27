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
    public FloatVariable DPC;
    public FloatVariable Score;

    public Upgrade[] UpgradeChain;
    public Item UnlockableItem;
    public GameEvent UnlockItemEvent;

    //TODO add IsUnlocked
    public void Buy()
    {
        if(Score.Value >= Cost)
        {
            Score.Value -= Cost;
            UpdatePrice();
            UpdateDPS();
            UpdateDPC();
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
            Debug.Log("items : " + NbItems + " " + UnlockableItem);
            UnlockNextItem();
        }
    }

    public void UpdateUpgradeChain()
    {
        if(!(_numberUpgradeDone > UpgradeChain.Length))
        {
            BaseMultiplier *= UpgradeChain[_numberUpgradeDone].Multiplier;
            UpdateDPS();
            UpdateDPC();
            ++_numberUpgradeDone;
            Debug.Log("UpdateUpgradeChain");
        }
    }
    
    private void UpdateDPS()
    {
        DPS.ApplyChange(BaseMultiplier * NbItems);
    }

    private void UpdateDPC()
    {
        DPC.ApplyChange(DPC.Value * NbItems);
    }

    public void Unlock()
    {
        this.IsUnlocked = true;
        UnlockItemEvent.Raise();
    }

    public void UnlockNextItem()
    {
		if(UnlockableItem != null && !UnlockableItem.IsUnlocked) 
        {
            UnlockableItem.Unlock();
        }
    }
}