using System;
using UnityEngine;

public static class GameplayEvents 
{
	public static Action<int> OnCoinsGained;
	public static Action<int> OnCoinTotalChanged;
	public static Action<Vector2> OnProjectileRequested;
	public static Action<Vector3> OnCheckpointReached;
}
