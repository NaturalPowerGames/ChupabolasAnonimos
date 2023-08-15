using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.GetComponent<MovementController>() != null)
		{
			GameplayEvents.OnCheckpointReached?.Invoke(transform.position);
		}
	}
}
