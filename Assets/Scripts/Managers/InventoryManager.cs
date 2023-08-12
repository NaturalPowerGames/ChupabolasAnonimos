using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private int totalCoins = 0;

	private void OnEnable()
	{
		GameplayEvents.OnCoinsGained += OnCoinsGained;
	}

	private void OnDisable()
	{
		GameplayEvents.OnCoinsGained -= OnCoinsGained;
	}

	private void OnCoinsGained(int amount)
	{
		totalCoins += amount;
		GameplayEvents.OnCoinTotalChanged?.Invoke(totalCoins);
	}
}
