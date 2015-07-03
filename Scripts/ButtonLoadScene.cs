using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonLoadScene : MonoBehaviour, IPointerDownHandler
{
	public string scene = "MainMenu";
	public void OnPointerDown(PointerEventData eventData)
	{
		Application.LoadLevel(scene);
	}
}
