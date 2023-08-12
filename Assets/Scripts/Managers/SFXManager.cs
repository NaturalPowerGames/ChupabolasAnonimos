using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
	public AudioClip[] clips;
	private AudioSource audioSource;

	private void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}

	private void OnEnable()
	{
		SFXEvents.OnSFXRequested += OnSFXRequested;
	}

	private void OnSFXRequested(SFX sfx)
	{
		if(clips.Length < (int) sfx || clips[(int)sfx] == null || audioSource == null)
		{
			Debug.Log("Sfx doesn't exist");
		}
		else
		audioSource.PlayOneShot(clips[(int)sfx]);
	}
}
