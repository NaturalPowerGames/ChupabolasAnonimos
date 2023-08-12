using UnityEngine;
using TMPro;

public class GameplayUIController : MonoBehaviour
{
	public TextMeshProUGUI coinAmountText;

	private void OnEnable()
	{
		GameplayEvents.OnCoinTotalChanged += OnCoinTotalChanged;
	}

	private void OnDisable()
	{
		GameplayEvents.OnCoinTotalChanged -= OnCoinTotalChanged;
	}

	private void OnCoinTotalChanged(int amount)
	{
		coinAmountText.text = $"Coins: {amount}";
	}
}
