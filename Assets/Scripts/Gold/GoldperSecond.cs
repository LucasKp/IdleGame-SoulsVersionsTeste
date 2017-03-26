using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GoldperSecond : MonoBehaviour
{
    public Text gpsDisplay;
    public double goldPerSecondEdit; // temporario
    public double goldPerSecond; 
    public GoldPerClick click;
    public ItemManager[] itens;

    public void Start()
    {
        goldPerSecondEdit = 0;
        StartCoroutine(AutoTick());
    }

    public void Update()
    {
            //gpsDisplay.text = GetGoldPerSecond() + " gold/sec";
            gpsDisplay.text = CurrencyConverter.Instance.GetCurrencyIntoString(GetGoldPerSecond(), true, false) + " damage/sec";
            goldPerSecond = GetGoldPerSecond();              
    }

	public double GetGoldPerSecond()
    {
		double tick = goldPerSecondEdit; //normal é 0
        foreach (ItemManager item in itens)
        {
            tick += item.count * item.tickValue;
        }        
        return tick;
    }

    public void AutoGoldPerSecond()
    {
        click.gold += GetGoldPerSecond() / 10;
    }

    private IEnumerator AutoTick()
    {
        while (true)
        {
            AutoGoldPerSecond();
            yield return new WaitForSeconds(0.10f);
        }
    }
}
