﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class doubleClick : MonoBehaviour, IPointerClickHandler {
	public GameObject PlayerDetails;

	public void OnPointerClick(PointerEventData eventData)
	{
		if (EventSystem.current.currentSelectedGameObject.name == "Cancel")
		{
			Debug.Log("first block");
			int tap = eventData.clickCount;
			if (tap == 2)
			{
				PlayerDetails.GetComponent<GameController> ().CancelDblClick ();
			}
		}
	}
}
