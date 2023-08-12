using UnityEngine;

public class CoinController : MonoBehaviour
{
	public int currencyAmount;
	public SFX sfx;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<MovementController>() != null)
		{
			TakeCoin();
		}
	}

	private void TakeCoin()
	{
		SFXEvents.OnSFXRequested?.Invoke(sfx);
		GameplayEvents.OnCoinsGained?.Invoke(currencyAmount);
		Destroy(gameObject);
	}
}
