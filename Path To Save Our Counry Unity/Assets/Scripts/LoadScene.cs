using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(nextScene());	
	}
	IEnumerator nextScene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Game1");
    }
	
}
