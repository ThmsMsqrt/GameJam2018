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
    public string StupidQuote;
    public int NbItemsSold;

    /// <summary>
    /// Calculate the new price of an object, based on a Super-Duper-Mega-Cool equation
    /// </summary>
    public void NewPrice()
    {
        float soldItemsFactor = Mathf.Pow(NbItemsSold, 1.15f);
        ActualPrice = Mathf.Ceil(BasePrice * soldItemsFactor);
        NbItemsSold += 1;
    }
}