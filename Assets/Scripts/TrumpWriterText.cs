using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TrumpWriterText : MonoBehaviour
{
    public float delay = 0.5f;
    public string fullText;
    private string curText = "";
    public bool startText = false;
    public bool clicked = false;
    public int playAudio = 0;
    public bool isPlaying = false;

    public int level = 0;


    public levelScript LevelManager;
    public frumpScripts frumpText;

    public AudioSource trump1;
    public AudioSource trump2;
    public AudioSource trump3;
    public AudioSource Cheering;

    private void Start()
    {
        gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
    }

    private void Update()
    {
        playAudio = LevelManager.GetComponent<levelScript>().response;
        level = LevelManager.GetComponent<levelScript>().level;

        
        if (level == 1)
        {
            if (playAudio == 1 && isPlaying)
            {
                this.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
                trump1.Play();
                fullText = frumpText.GetComponent<frumpScripts>().Lvl1Option1;
                StartCoroutine(RevealText());
                isPlaying = false;
                clicked = false;
            }
            else if (playAudio == 2 && isPlaying)
            {
                this.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
                trump2.Play();
                fullText = frumpText.GetComponent<frumpScripts>().Lvl1Option2;
                StartCoroutine(RevealText());
                isPlaying = false;
                clicked = false;
            }
            else if (playAudio == 3 && isPlaying)
            {
                this.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
                trump3.Play();
                fullText = frumpText.GetComponent<frumpScripts>().Lvl1Option3;
                StartCoroutine(RevealText());
                isPlaying = false;
                clicked = false;
            }
        }
        else if (level == 2)
        {
            if (playAudio == 1 && isPlaying)
            {
                this.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
                trump1.Play();
                fullText = frumpText.GetComponent<frumpScripts>().Lvl2Option1;
                StartCoroutine(RevealText());
                isPlaying = false;
                clicked = false;
            }
            else if (playAudio == 2 && isPlaying)
            {
                this.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
                trump2.Play();
                fullText = frumpText.GetComponent<frumpScripts>().Lvl2Option2;
                StartCoroutine(RevealText());
                isPlaying = false;
                clicked = false;
            }
            else if (playAudio == 3 && isPlaying)
            {
                this.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
                trump3.Play();
                fullText = frumpText.GetComponent<frumpScripts>().Lvl2Option3;
                StartCoroutine(RevealText());
                isPlaying = false;
                clicked = false;
            }
        }
        else if (level == 2)
        {
            if (playAudio == 1 && isPlaying)
            {
                this.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
                trump1.Play();
                fullText = frumpText.GetComponent<frumpScripts>().Lvl3Option1;
                StartCoroutine(RevealText());
                isPlaying = false;
                clicked = false;
            }
            else if (playAudio == 2 && isPlaying)
            {
                this.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
                trump2.Play();
                fullText = frumpText.GetComponent<frumpScripts>().Lvl3Option2;
                StartCoroutine(RevealText());
                isPlaying = false;
                clicked = false;
            }
            else if (playAudio == 3 && isPlaying)
            {
                this.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
                trump3.Play();
                fullText = frumpText.GetComponent<frumpScripts>().Lvl3Option3;
                StartCoroutine(RevealText());
                isPlaying = false;
                clicked = false;
            }
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
        Cheering.Play();
    }




}
