using UnityEngine;
using UnityEngine.UI;

public class GoldPerClick : MonoBehaviour 
{
	public Text goldDisplay;
    public Text goldPerClick;
    public double gold = 0;
	public int goldperClick;

    public void Start()
	{
        goldperClick = 1;
        gold = 0;
    }

	public void Update()
    {
            goldDisplay.text = "Damage: " + CurrencyConverter.Instance.GetCurrencyIntoString(gold, false, false);
            goldPerClick.text = CurrencyConverter.Instance.GetCurrencyIntoString(goldperClick, false, true);
            // + " gold/Click"        
    }

    public void Clicker()
	{
		gold = gold + goldperClick;
	}
}
