using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class endGameScript : MonoBehaviour
{
    public float delay = 0.5f;

    string fullText;
    string curText = "";
    int playAudio = 0;

    bool done = false;
    float timer = 0;

    public levelScript LevelManager;
    public frumpScripts frumpText;


    private void Update()
    {
        playAudio = LevelManager.GetComponent<levelScript>().response;

        if (playAudio == 1 && !done)
        {
            fullText = frumpText.GetComponent<frumpScripts>().BadEnding;
            StartCoroutine(RevealText());
        }
        else if (playAudio == 2 && !done)
        {
            fullText = frumpText.GetComponent<frumpScripts>().StupidEnding;
            StartCoroutine(RevealText());
        }
        else if (playAudio == 3 && !done)
        {
            fullText = frumpText.GetComponent<frumpScripts>().PerfectEnding;
            StartCoroutine(RevealText());
        }

        
        done = true;

        
    }

    private IEnumerator RevealText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            curText = fullText.Substring(0, i);
            this.GetComponent<TextMeshPro>().text = curText;
            yield return new WaitForSeconds(delay);
        }
    }
}
