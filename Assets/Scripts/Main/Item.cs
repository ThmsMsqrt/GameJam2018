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

    //TODO add IsUnlocked
    public void Buy()
    {
        if(Score.Value >= Cost)
        {
			//increase the nb of items by 1, pay the cost, increase the cost of next item
			NbItems ++;
			Score.Value -= Cost;
			UpdatePrice();


			//Update the DPS and DPC to fit the new nbItems
			UpdateDPS();
            //UpdateDPC();
        }
    }

    /// <summary>
    /// Calculate the new price of an object, based on a Super-Duper-Mega-Cool equation
    /// </summary>
    public void UpdatePrice()
    {
        float soldItemsFactor = Mathf.Pow(NbItems, BaseMultiplier);
		Cost = Mathf.Ceil(BasePrice * (soldItemsFactor+1));
    }

    public void UpdateUpgradeChain()
    {
        if(!(_numberUpgradeDone > UpgradeChain.Length))
        {
			//BaseMultiplier *= UpgradeChain[_numberUpgradeDone].Multiplier;
            BaseMultiplier *= 2;
            UpdateDPS();
            //UpdateDPC();
            ++_numberUpgradeDone;
            Debug.Log("UpdateUpgradeChain");
        }
    }
    
    private void UpdateDPS()
	{
		//DPS.ApplyChange(BaseMultiplier * NbItems);
		// redo the whole calculation becuase someone is having a trackes to when yoiu are using multipliers
		DPS.ApplyChange(( NbItems  * DPSBase * DPSMultiplier) - ((NbItems-1) * DPSBase * DPSMultiplier));
    }

	//items do not do an click upgrade now
    //private void UpdateDPC()
    //{
    //    DPC.ApplyChange(DPC.Value * NbItems);
    //}
}