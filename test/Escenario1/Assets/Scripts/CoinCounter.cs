using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
	public int currentNumberOfCoins;

	public void GetCoins(int cointAmount)
	{
		currentNumberOfCoins += cointAmount;

		Debug.Log("he recogido una moneda, tengo: " + currentNumberOfCoins + "monedas");
	}
}