using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ItemDropHandler : MonoBehaviour, IDropHandler
{
	public GameObject salt;
	public GameObject pepper;
	public GameObject sauce;
	private GameObject dupe;

	
	public void OnDrop(PointerEventData eventData)
	{
		RectTransform invPanel = transform as RectTransform;
		
		if (!RectTransformUtility.RectangleContainsScreenPoint(invPanel, Input.mousePosition))
		{

			if (ItemDragHandler.tag == "Salt Sprite")
			{
				dupe = Instantiate(salt);
			
				if (CoinSystem.total >= 2)	
				{
					CoinSystem.total -= 2;
				}
			}

			else if (ItemDragHandler.tag == "Pepper Sprite")
			{
		
				dupe = Instantiate(pepper);
				if (CoinSystem.total >= 2)	
				{
					CoinSystem.total -= 2;
				}
			}
			
			
			else if (ItemDragHandler.tag == "Hot Sauce Sprite")
			{
		
				dupe = Instantiate(sauce);
				if (CoinSystem.total >= 5)	
				{
					CoinSystem.total -= 5;
				}
			}
			
			dupe.SetActive(true);
		}
	}
}
