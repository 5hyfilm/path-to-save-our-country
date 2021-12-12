using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour {
	
	public string HoldItem = "";
	public Image BinUI;

	void Update()
	{
		if (HoldItem == "")
		{
            BinUI.color = new Color(0,0,0,0);
        }
        else if (HoldItem == "Wet")
		{
			BinUI.color = new Color(0,153,0,255);
		}
        else if (HoldItem == "Danger")
		{
            BinUI.color = new Color(220, 0, 0, 255);
        }

        else if (HoldItem == "General")
		{
			BinUI.color = new Color(0,102,204,255);
		}
        else if (HoldItem == "Recycle")
		{
			BinUI.color = new Color(255,213,0,255);
		}
	}

	// Use this for initialization
	public bool AddItem(string item)
	{
		if (HoldItem == "")
		{
			HoldItem = item;
			return true;
		}
		else
		{
			return false;
		}
	}
}
