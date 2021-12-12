using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHover : MonoBehaviour
{
	public Text BtnText;
	public Outline Stroke;
	void OnMouseOver ()
	{
		BtnText.color = Color.white;
		Stroke.enabled = true;
	}
	
	// Update is called once per frame
	void OnMouseExit() {
		BtnText.color = new Color(50,50,50,255);
		Stroke.enabled = false;
	}
}
