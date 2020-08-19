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

    public AudioSource trump1;
    public AudioSource trump2;
    public AudioSource trump3;

    private void Update()
    {
        if (startText)
        {
            StartCoroutine(RevealText());
            startText = false;
         
        }

        if (playAudio == 1 && isPlaying)
        {
            this.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
            trump1.Play();
            fullText = "My people tell me coal is the issue, and my people are the best. So I said the only solution is to burn all the coal and get rid of it, And that WAS my idea. My people were amazed. They hadn’t thought of that. They literally gasped at how good the idea was.";
            StartCoroutine(RevealText());
            isPlaying = false;
            clicked = false;
        }
        else if (playAudio == 2 && isPlaying)
        {
            this.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
            trump2.Play();
            fullText = "You know I did some research, very in-depth research and discovered that factories are the problem. I discovered this myself.So I’m shutting down our factories, I can do that you know.And I'll be sending our production to CHINA. China is very advanced. A very advanced people. Some of the most advanced I've been told.Not only does this help the environment.It also creates jobs now that people don’t have to work in those terrible factories.";
            StartCoroutine(RevealText());
            isPlaying = false;
            clicked = false;
        }
        if (playAudio == 3 && isPlaying)
        {
            this.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
            trump3.Play();
            fullText = "People do not think “America the great” when they hear 2nd place, this is what i’ve always said. I promised to make USA number 1 and that's what I plan to do. We are getting rid of those old fossil fuels, that's what fossil means. And be focusing on renewable resources like coal. You know I made some coal in my fireplace the other day, and the brilliant idea came to me. We just make more coal and use that power. This ensures we get number one in the carbon mission.";
            StartCoroutine(RevealText());
            isPlaying = false;
            clicked = false;
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
            clicked = true;
        }
    }


}
