using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
	[SerializeField]
	private Player player;

	private void Awake()
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
		player = new Player();
		player.coins = 0;
		player.currentLocation = Vector3.zero;
		player.ID = "mamaguevo";
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
