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
    public float ActualPrice;
    public float BaseMultiplier = 1.15f;
    public string StupidQuote;
    public int NbItemsSold;

    public Upgrade[] UpgradeChain;
    private int _numberUpgradeDone;

    /// <summary>
    /// Calculate the new price of an object, based on a Super-Duper-Mega-Cool equation
    /// </summary>
    public void NewPrice()
    {
        float soldItemsFactor = Mathf.Pow(NbItemsSold, BaseMultiplier);
        ActualPrice = Mathf.Ceil(BasePrice * soldItemsFactor);
        NbItemsSold += 1;
    }

    public void UpdateUpgradeChain()
    {
        if(!(_numberUpgradeDone > UpgradeChain.Length))
        {
            BaseMultiplier *= UpgradeChain[_numberUpgradeDone].Multiplier;
            ++_numberUpgradeDone;
        }
    }
}