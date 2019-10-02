using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class finalLapTextScript : MonoBehaviour
{
    private bool finalLap;
    private Text text;
    private  float duration = 1.0f; //0.5 secs
    private float currentTime = 0f;

    void Start() {
        text = GetComponent<Text>();

        text.color = new Color(text.color.r, text.color.g, text.color.b, 0.0f);
    }
    void Update() {
        finalLap = lapScript.finalLap;
        
        if (finalLap)
        {
            LL();
        }
    }
    public void LL()
    {

            StartCoroutine(FadeTextToFullAlpha());
    }
 
 
    public IEnumerator FadeTextToFullAlpha()
    {
        currentTime = 0.0f;
        while(currentTime < duration)
        {
            float alpha = Mathf.Lerp(0f, 1f, currentTime/duration);
            text.color = new Color(text.color.r, text.color.g, text.color.b, alpha);
            currentTime += Time.deltaTime;
            yield return null;
        }

        currentTime = 0.0f;
        while(currentTime < duration)
        {
            float alpha = Mathf.Lerp(1f, 0f, currentTime/duration);
            text.color = new Color(text.color.r, text.color.g, text.color.b, alpha);
            currentTime += Time.deltaTime;
            yield return null;
        }
        //text.text = "";

        yield break;
    }
 
}
