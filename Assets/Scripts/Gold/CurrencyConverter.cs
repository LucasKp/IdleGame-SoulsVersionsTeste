using UnityEngine;
using System.Collections;

public class CurrencyConverter : MonoBehaviour 
{
	private static CurrencyConverter instance;

	public static CurrencyConverter Instance
	{
		get 
		{
			return instance;
		}
	}

	void Awake()
	{
		CreateInstance();
	}

	void CreateInstance()
	{
		if (instance == null) 
		{
			instance = this;
		}
	}

	public string GetCurrencyIntoString(double valueToConvert, bool currencyPerSecond, bool currencyPerClick)
	{
		string converted;

        //if (valueToConvert >= 1000000000000000000000)
        //{
        //    converted = (valueToConvert / 1000000000000000000000).ToString("f3") + "s";
        //}

        if (valueToConvert >= 1000000000000000000)
        {
            converted = (valueToConvert / 1000000000000000000).ToString("f3") + "Q";
        }

        if (valueToConvert >= 1000000000000000)
        {
            converted = (valueToConvert / 1000000000000000f).ToString("f3") + "q";
        }

        if (valueToConvert >= 1000000000000) 
		{
			converted = (valueToConvert / 1000000000000f).ToString ("f3") + "T";
		}

		else if (valueToConvert >= 1000000000) 
		{
			converted = (valueToConvert / 1000000000f).ToString ("f3") + "B";
		}

		else if (valueToConvert >= 1000000) 
		{
			converted = (valueToConvert / 1000000f).ToString ("f3") + "M";
		}

		else if (valueToConvert >= 1000)
		{
			converted = (valueToConvert / 1000f).ToString ("f3") + "K";
		}

		else
		{
			converted = "" + valueToConvert.ToString ("f0");
		}

		if (currencyPerClick == true)
		{
            //converted = converted + "goldPerClick";
            return converted + " Damage";
		}

		//if (currencyPerSecond == true) 
		//{
		//	converted = converted + " goldDisplay";
		//}

		return converted;
	}
}
