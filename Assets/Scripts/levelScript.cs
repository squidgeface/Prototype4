using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class levelScript : MonoBehaviour
{
 
    public GameObject Dialogue;
    public GameObject Dialogue2;
    public GameObject Dialogue3;
    public GameObject TrumpDialogue;
    public ScoreScript ScoreCounter;
    public int level = 1;

    public int advisorClicked = 0;

    bool activateDialogue = false;

    private void Start()
    {
        ScoreCounter = FindObjectOfType<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Dialogue.GetComponent<typewriterText>().clicked)
        {
            Dialogue.GetComponent<typewriterText>().fullText = "";
            Dialogue.GetComponent<TextMeshPro>().text = "";
            Dialogue.GetComponentInChildren<SpriteRenderer>().enabled = false;
            Dialogue2.GetComponent<typewriterText>().fullText = "";
            Dialogue2.GetComponent<TextMeshPro>().text = "";
            Dialogue2.GetComponentInChildren<SpriteRenderer>().enabled = false;
            Dialogue3.GetComponent<typewriterText>().fullText = "";
            Dialogue3.GetComponent<TextMeshPro>().text = "";
            Dialogue3.GetComponentInChildren<SpriteRenderer>().enabled = false;
            TrumpDialogue.GetComponent<typewriterText>().isPlaying = true;
            TrumpDialogue.GetComponent<typewriterText>().playAudio = 1;
            Dialogue.GetComponent<typewriterText>().clicked = false;
            ScoreCounter.GoodScore += 1;
        }
        else if (Dialogue2.GetComponent<typewriterText>().clicked)
        {
            Dialogue.GetComponent<typewriterText>().fullText = "";
            Dialogue.GetComponent<TextMeshPro>().text = "";
            Dialogue.GetComponentInChildren<SpriteRenderer>().enabled = false;
            Dialogue2.GetComponent<typewriterText>().fullText = "";
            Dialogue2.GetComponent<TextMeshPro>().text = "";
            Dialogue2.GetComponentInChildren<SpriteRenderer>().enabled = false;
            Dialogue3.GetComponent<typewriterText>().fullText = "";
            Dialogue3.GetComponent<TextMeshPro>().text = "";
            Dialogue3.GetComponentInChildren<SpriteRenderer>().enabled = false;
            TrumpDialogue.GetComponent<typewriterText>().isPlaying = true;
            TrumpDialogue.GetComponent<typewriterText>().playAudio = 2;
            Dialogue2.GetComponent<typewriterText>().clicked = false;
            ScoreCounter.StupidScore += 1;
        }
        else if (Dialogue3.GetComponent<typewriterText>().clicked)
        {
            Dialogue.GetComponent<typewriterText>().fullText = "";
            Dialogue.GetComponent<TextMeshPro>().text = "";
            Dialogue.GetComponentInChildren<SpriteRenderer>().enabled = false;
            Dialogue2.GetComponent<typewriterText>().fullText = "";
            Dialogue2.GetComponent<TextMeshPro>().text = "";
            Dialogue2.GetComponentInChildren<SpriteRenderer>().enabled = false;
            Dialogue3.GetComponent<typewriterText>().fullText = "";
            Dialogue3.GetComponent<TextMeshPro>().text = "";
            Dialogue3.GetComponentInChildren<SpriteRenderer>().enabled = false;
            TrumpDialogue.GetComponent<typewriterText>().isPlaying = true;
            TrumpDialogue.GetComponent<typewriterText>().playAudio = 3;
            Dialogue3.GetComponent<typewriterText>().clicked = false;
            ScoreCounter.EvilScore += 1;
        }

    }

}
