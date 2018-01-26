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
    public float BasePrice;
    public float PriceIncrease;
    public string StupidQuote;
    public int NbItemsSold;

    public void NewPrice()
    {
        BasePrice *= Mathf.Pow(PriceIncrease, NbItemsSold);
        NbItemsSold += 1;
    }
}