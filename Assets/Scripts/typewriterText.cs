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
    public bool isPlaying = false;

    public int level = 0;

    public int advisor = 0;
    public int tracker = 0;

    public levelScript LevelManager;
    public AdvisorScripts advisorText;
    public Advisors advisorNum;
    public TrumpWriterText trumpScript;
    public GameObject advisorGO;


    private void Start()
    {
        gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
        gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
    }

    private void Update()
    {
       if (LevelManager.GetComponent<levelScript>().advisorClicked != advisor)
       {
            startText = advisorNum.GetComponent<Advisors>().clicked;
            level = LevelManager.GetComponent<levelScript>().level;
       }

       if (LevelManager.GetComponent<levelScript>().advisorClicked == advisor)
       {
            gameObject.GetComponentInChildren<BoxCollider>().enabled = true;
       }

        if (LevelManager.GetComponent<levelScript>().advisorClicked != 0)
        {
            advisorGO.GetComponent<SphereCollider>().enabled = false;
        }


        if (startText)
        {
            LevelManager.GetComponent<levelScript>().advisorClicked = advisor;
            gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
            gameObject.GetComponentInChildren<BoxCollider>().enabled = true;

            if (advisorNum.GetComponent<Advisors>().advisorNum == 1)
            {
                if (LevelManager.GetComponent<levelScript>().level == 1)
                {
                    curText = advisorText.GetComponent<AdvisorScripts>().goodLvl1;
                    playAudio = 1;
                    tracker = 1;
                }
                else if (LevelManager.GetComponent<levelScript>().level == 2)
                {
                    curText = advisorText.GetComponent<AdvisorScripts>().goodLvl2;
                }
                else if (LevelManager.GetComponent<levelScript>().level == 3)
                {
                    curText = advisorText.GetComponent<AdvisorScripts>().goodLvl3;
                }

            }
            else if (advisorNum.GetComponent<Advisors>().advisorNum == 2)
            {
                if (LevelManager.GetComponent<levelScript>().level == 1)
                {
                    curText = advisorText.GetComponent<AdvisorScripts>().stupidLvl1;
                    playAudio = 2;
                    tracker = 2;
                }
                else if (LevelManager.GetComponent<levelScript>().level == 2)
                {
                    curText = advisorText.GetComponent<AdvisorScripts>().stupidLvl2;
                }
                else if (LevelManager.GetComponent<levelScript>().level == 3)
                {
                    curText = advisorText.GetComponent<AdvisorScripts>().stupidLvl3;
                }

            }    
            else if (advisorNum.GetComponent<Advisors>().advisorNum == 3)
            {
                if (LevelManager.GetComponent<levelScript>().level == 1)
                {
                    curText = advisorText.GetComponent<AdvisorScripts>().evilLvl1;
                    playAudio = 3;
                    tracker = 3;
                }
                else if (LevelManager.GetComponent<levelScript>().level == 2)
                {
                    curText = advisorText.GetComponent<AdvisorScripts>().evilLvl2;
                }
                else if (LevelManager.GetComponent<levelScript>().level == 3)
                {
                    curText = advisorText.GetComponent<AdvisorScripts>().evilLvl3;
                }

            }
            StartCoroutine(RevealText());
            advisorNum.GetComponent<Advisors>().clicked = false;
            startText = false;
         
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

    void OnMouseDown()
    {
        if (!clicked)
        {
            trumpScript.GetComponent<TrumpWriterText>().isPlaying = true;
            trumpScript.GetComponent<TrumpWriterText>().playAudio = advisor;
        }
    }


}
