using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingAudio : MonoBehaviour
{
    private int response = 0;
    private bool Played = true;

    public AudioSource Source;
    public AudioClip Perfect;
    public AudioClip Good;
    public AudioClip Stupid;
    public AudioClip Evil;

    // Start is called before the first frame update
    void Start()
    {
        Source = GetComponent<AudioSource>();
        response = FindObjectOfType<ScoreScript>().response;
    }

    // Update is called once per frame
    void Update()
    {
        if (Played)
        {
            //Perfect
            if (response == 4)
            {
                Source.clip = Perfect;
                Source.Play();
            }
            //Good
            else if (response == 3)
            {
                Source.clip = Good;
                Source.Play();
            }
            //Stupid
            else if (response == 2)
            {
                Source.clip = Stupid;
                Source.Play();
            }
            //Evil
            else if (response == 1)
            {
                Source.clip = Evil;
                Source.Play();
            }

            Played = false;
        }
    }
}
