using ScriptableFramework.Variables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Item")]
public class Item : ScriptableObject
{
    public string Name;
    public Sprite Image;
    public string Description;
    public float BasePrice = 0;
    public float CurrentPrice;
    public float BaseMultiplier = 1.15f;
    public string StupidQuote;
    public int NbItems;

    public Upgrade[] UpgradeChain;
    private int _numberUpgradeDone;
    
    public FloatVariable DPS;
    public FloatVariable Score;

    public void Buy()
    {
        Score.Value -= CurrentPrice;
        UpdatePrice();
        UpdateDPS();
    }

    /// <summary>
    /// Calculate the new price of an object, based on a Super-Duper-Mega-Cool equation
    /// </summary>
    public void UpdatePrice()
    {
        float soldItemsFactor = Mathf.Pow(NbItems, BaseMultiplier);
        CurrentPrice = Mathf.Ceil(BasePrice * soldItemsFactor);
        NbItems += 1;
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

    public void UpdateDPS()
    {
        DPS.Value *= (BaseMultiplier * NbItems);
    }
}