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
	
	public GameObject Cover1;
	public GameObject Cover2;
	public GameObject Cover3;

	public GameObject SaltButton;
	public GameObject PepperButton;
	public GameObject SauceButton;

	public void stb()
    {
        SaltButton.SetActive(true);
    }

	public void pb()
    {
        PepperButton.SetActive(true);
    }

	public void sb()
    {
        SauceButton.SetActive(true);
    }


	public void Covers1()
    {
        Cover1.SetActive(true);
    }

	public void Covers2()
    {
        Cover2.SetActive(true);
    }

	public void Covers3()
    {
        Cover3.SetActive(true);
    }

	
	public void OnDrop(PointerEventData eventData)
	{
		RectTransform invPanel = transform as RectTransform;
		
		if (!RectTransformUtility.RectangleContainsScreenPoint(invPanel, Input.mousePosition))
		{

			if (ItemDragHandler.tag == "Salt Sprite")
			{
				
				
			
				if (CoinSystem.total >= 2)	
				{
					dupe = Instantiate(salt);
					CoinSystem.total -= 2;
					Covers1();
					stb();
				}
			}

			else if (ItemDragHandler.tag == "Pepper Sprite")
			{
		
				if (CoinSystem.total >= 2)	
				{
					dupe = Instantiate(pepper);
					CoinSystem.total -= 2;
					Covers2();
					pb();
				}
			}
			
			
			else if (ItemDragHandler.tag == "Hot Sauce Sprite")
			{
		
				if (CoinSystem.total >= 5)	
				{
					dupe = Instantiate(sauce);
					CoinSystem.total -= 5;
					Covers3();
					sb();
				}
			}
			
			dupe.SetActive(true);
		}
	}
}
