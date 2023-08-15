using UnityEngine;
using TMPro;
using System;
using System.Collections;

public class GameplayUIController : MonoBehaviour
{
	public TextMeshProUGUI coinAmountText, checkpointReachedText;

	private void OnEnable()
	{
		GameplayEvents.OnCoinTotalChanged += OnCoinTotalChanged;
		GameplayEvents.OnCheckpointReached += OnCheckpointReached;
	}

	private void OnDisable()
	{
		GameplayEvents.OnCoinTotalChanged -= OnCoinTotalChanged;
	}

	private void OnCoinTotalChanged(int amount)
	{
		coinAmountText.text = $"Coins: {amount}";
	}

	private void OnCheckpointReached(Vector3 obj)
	{
		checkpointReachedText.gameObject.SetActive(true);
		StartCoroutine(WaitThenDeactivateObject(checkpointReachedText.gameObject));
	}

	private IEnumerator WaitThenDeactivateObject(GameObject gameObjectToDeactivate)
	{
		yield return new WaitForSeconds(2);
		gameObjectToDeactivate.SetActive(false);
	}
}
