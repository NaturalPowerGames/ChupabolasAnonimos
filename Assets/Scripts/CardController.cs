using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class CardController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
	public Color hoverColor;
	private Color baseColor;
	private Image image;

	private void Awake()
	{
		image = GetComponent<Image>();
		baseColor = image.color;
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		image.DOColor(hoverColor, 1);
		transform.DOScale(2, 1);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		image.DOColor(baseColor, 1);
		transform.DOScale(1, 1);
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		float randomMovement = UnityEngine.Random.Range(-250, 250);
		transform.DOMoveY(transform.position.y + randomMovement, 1).SetLoops(-1, LoopType.Yoyo);
		transform.DOShakeRotation(1, 100, 15);
	}
}
