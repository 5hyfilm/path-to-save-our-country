using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class FinishScript : MonoBehaviour
{
	public Text Score;
	public Text HighScore; 
	// Use this for initialization
	void Start ()
	{
		if (PlayerPrefs.GetFloat("Score") > PlayerPrefs.GetFloat("HighScore"))
			PlayerPrefs.SetFloat("HighScore",PlayerPrefs.GetFloat("Score"));
		HighScore.text = "Highest Score :     "+PlayerPrefs.GetFloat("HighScore");
		Score.text = "Your Score :          "+PlayerPrefs.GetFloat("Score");
	}
}
