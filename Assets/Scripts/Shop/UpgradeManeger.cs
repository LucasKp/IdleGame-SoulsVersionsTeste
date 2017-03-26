using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeManeger : MonoBehaviour 
{
	public Text itemInfo;    
	public GoldPerClick click;
	public double cost;
	private double baseCost;
	public int count;
	public int clickPower;
	public string itemName;
	public double upCost;

    public void Start()
    {
        baseCost = cost;
    }

	public void Update()
	{
		//itemInfo.text = itemName + "\nCost: " + cost + "\nPower: +" + clickPower;
        itemInfo.text = itemName + "\nCost: " + CurrencyConverter.Instance.GetCurrencyIntoString(cost, false, true) + "\nAdd Damage: +" + clickPower;       
    }

	public void PurchasedUpgrade()
	{
		if (click.gold >= cost) 
		{
			click.gold = click.gold - cost;
			count = count + 1;
			click.goldperClick = click.goldperClick + clickPower;
			upCost = Mathf.Pow(1.15f, count);
			cost = (baseCost + upCost); //Normal is 1.10
		}
	}
}
