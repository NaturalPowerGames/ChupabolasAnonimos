using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
	[SerializeField]
	private Player player;

	private void Start()
	{
		SetPlayer();
	}

	private void OnEnable()
	{
		GameplayEvents.OnCheckpointReached += OnCheckpointReached;
		GameplayEvents.OnCoinTotalChanged += OnCoinTotalChanged;
	}

	private void SetPlayer()
	{
		Player loaded = SaverLoader.LoadSave();
		if(loaded == null)
		{
			player = new Player();
			player.coins = 0;
			player.currentLocation = Vector3.zero;
			player.ID = "mamaguevo";
		}
		else
		{
			player = loaded;
			GameplayEvents.OnCoinsGained?.Invoke(player.coins);
			GameplayEvents.OnPlayerTeleportRequested?.Invoke(player.currentLocation);
		}	
	}

	private void OnCheckpointReached(Vector3 location)
	{
		player.currentLocation = location;
		SaverLoader.Save(player);
	}

	private void OnCoinTotalChanged(int total)
	{
		player.coins = total;
		SaverLoader.Save(player);
	}
}
