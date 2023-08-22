using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MovementController : MonoBehaviour, IPointerEnterHandler
{
    public float moveSpeed;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

	private void OnEnable()
	{
        GameplayEvents.OnPlayerTeleportRequested += OnPlayerTeleportRequested;
	}

	private void OnPlayerTeleportRequested(Vector3 location)
	{
        transform.position = location;
	}

	private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.position += new Vector3(x, y, 0) * moveSpeed;

		if (Input.GetKeyDown(KeyCode.Space))
		{
            spriteRenderer.color = Color.red;            
		}
    }

	public void OnPointerEnter(PointerEventData eventData)
	{
        Debug.Log("Pointer entered: " + name);
	}
}
