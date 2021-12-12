using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteScripts : MonoBehaviour
{
	private InventorySystem ItemMan;
	private PlayerController Player;
	public int ScorePerPiece;
	public int WrongBin;

	private string tagcheck;

	void Start()
	{
		ItemMan = FindObjectOfType<InventorySystem>();
		Player = FindObjectOfType<PlayerController>();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			
			if (CompareTag("Wet") || CompareTag("Danger") || CompareTag("General") || CompareTag("Recycle"))
			{
				Debug.Log(tag);
				if (ItemMan.AddItem(tag))
					Destroy(gameObject);
			}

			if (CompareTag("WetBin") || CompareTag("DangerBin") || CompareTag("GeneralBin") || CompareTag("RecycleBin"))
			{
				Debug.Log(tag);
				if (tag.Replace("Bin", "")==ItemMan.HoldItem)
				{
					Player.AddScore(ScorePerPiece);
                    ItemMan.HoldItem = "";
				}
				else if(ItemMan.HoldItem != "")
				{
					Player.AddScore(-WrongBin);
					ItemMan.HoldItem = "";
				}
			}
		}
	}
}
