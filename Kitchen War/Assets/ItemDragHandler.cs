using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{
	static public string tag;
	
	public void OnDrag(PointerEventData eventData)
	{
		transform.position = Input.mousePosition;
		tag = gameObject.tag;
	}
	
	public void OnEndDrag(PointerEventData eventData)
	{
		transform.localPosition = Vector3.zero;
	}
}
