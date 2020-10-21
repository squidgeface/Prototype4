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


    public bool isPlaying = true;
    public int level = 0;


    private bool done = false;
    private float timer = 0;

    public levelScript LevelManager;
    public AudioSource umm;
    public AudioSource Reporter;

    private void Start()
    {
        gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;

    }

    private void Update()
    {
       
        timer += Time.deltaTime;
        
        if (timer > 5 && done == false)
        {
            LevelManager.GetComponent<levelScript>().Clicked = true;
            Reporter.Play();
            done = true;
            timer = 0;
        }

        if (done && timer > 7 && LevelManager.GetComponent<levelScript>().level < 6)
        {
            if (FindObjectOfType<CameraMover>().activated == false)
            {
                // FindObjectOfType<ScoreScript>().level += 1;
            }

            FindObjectOfType<CameraMover>().activated = true;
            gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
            this.GetComponent<TextMeshPro>().text = "";

            umm.Play();
            timer = 0;
        }
        else if (done && timer > 10 && LevelManager.GetComponent<levelScript>().level >= 6)
        {
            if (FindObjectOfType<CameraMover>().activated == false)
            {
                // FindObjectOfType<ScoreScript>().level += 1;
            }

            FindObjectOfType<CameraMover>().activated = true;
            gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
            this.GetComponent<TextMeshPro>().text = "";

            umm.Play();
            timer = 0;
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
