using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingAnim : MonoBehaviour {
    public Text Fulltext;
    public float speed;
    private float timer;
    void Start()
    {
        StartCoroutine(ShowText());
    }
    void FixedUpdate()
    {
        timer += Time.deltaTime;
    }
    IEnumerator ShowText()
    {
        while(timer < 10)
        {
            Fulltext.text = "";
            yield return new WaitForSeconds(speed);
            //currentText = /*fullText.Substring(0, i);*/
            Fulltext.text = ".";
            yield return new WaitForSeconds(speed);
            Fulltext.text = ". .";
            yield return new WaitForSeconds(speed);
            Fulltext.text = ". . .";
            yield return new WaitForSeconds(speed);

        }
    }
}
