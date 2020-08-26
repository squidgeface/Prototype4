using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class typewriterText : MonoBehaviour
{
    public float delay = 0.5f;

    public string fullText;
    private string curText = "";
    public bool startText = false;
    public bool clicked = false;
    public int playAudio = 0;
    public bool isPlaying = true;
    public int level = 0;

    private bool bTimer = false;
    private bool done = false;
    private float timer = 0;

    public levelScript LevelManager;

    private void Start()
    {
        gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
        bTimer = true;
    }

    private void Update()
    {
        if (bTimer)
        {
            timer += Time.deltaTime;
        }
        if (timer > 5 && done == false)
        {
            LevelManager.GetComponent<levelScript>().Clicked = true;
            done = true;
        }

        if (timer > 15)
        {
            FindObjectOfType<CameraMover>().activated = true;
        }

       level = LevelManager.GetComponent<levelScript>().level;
       startText = LevelManager.GetComponent<levelScript>().Clicked;

        if (startText && isPlaying)
        {
            gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
            gameObject.GetComponentInChildren<BoxCollider>().enabled = true;
            StartCoroutine(RevealText());
          
            startText = false;
            isPlaying = false;
        }
        
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
