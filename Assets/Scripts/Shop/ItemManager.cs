using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public Text itemInfo;
    public GoldPerClick click;
	public float cost;
	private float baseCost;
    public double tickValue;
    public int count;
    public string itemName;    
	public float upCost;

    public void Start()
    {
        baseCost = cost;
    }

    public void Update()
    {
        //itemInfo.text = itemName + "\nCost: " + cost + "\nGold: " + tickValue + "s";    
        itemInfo.text = itemName + "\nCost: " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, true, false) + "\nDamage: + " +
           CurrencyConverter.Instance.GetCurrencyIntoString(tickValue, true, false) + " damage/s";        
    }

    public void PurchasedItem()
    {
        if (click.gold >= cost)
        {
            click.gold = click.gold - cost;
            count = count + 1;
			upCost = Mathf.Pow(1.15f, count);
			cost = (baseCost + upCost); //Normal is 1.10
        }
    }
}
