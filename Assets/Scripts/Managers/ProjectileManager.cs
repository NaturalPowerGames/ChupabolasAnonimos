using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
	public ProjectileController projectilePrefab;

	private void OnEnable()
	{
		GameplayEvents.OnProjectileRequested += OnProjectileRequested;
	}

	private void OnProjectileRequested(Vector2 origin)
	{
		ProjectileController projectile = Instantiate(projectilePrefab, origin, Quaternion.identity);		
	}
}
