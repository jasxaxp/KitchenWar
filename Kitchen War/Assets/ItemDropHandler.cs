using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDropHandler : MonoBehaviour, IDropHandler
{
	public GameObject salt;
	public GameObject pepper;
	public GameObject sauce;
	private GameObject dupe;
	
	public void OnDrop(PointerEventData eventData)
	{
		Vector3 dist;
        Vector3 startPos;
        float posX;
        float posZ;
        float posY;
		RectTransform invPanel = transform as RectTransform;
		
		if (!RectTransformUtility.RectangleContainsScreenPoint(invPanel, Input.mousePosition))
		{
			if (ItemDragHandler.tag == "Salt Sprite")
			{
				dupe = Instantiate(salt);
			}
			
			else if (ItemDragHandler.tag == "Pepper Sprite")
			{
				dupe = Instantiate(pepper);
			}
			
			else if (ItemDragHandler.tag == "Hot Sauce Sprite")
			{
				dupe = Instantiate(sauce);
			}
			
			dupe.SetActive(true);
		}
	}
}
