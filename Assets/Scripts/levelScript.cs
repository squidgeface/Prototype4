using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class levelScript : MonoBehaviour
{

    public GameObject TrumpDialogue;
    public ScoreScript ScoreCounter;
    public int level = 1;

    public bool Clicked = false;

  

    private void Start()
    {
        ScoreCounter = FindObjectOfType<ScoreScript>();
    }

  

    public void Click()
    {
        Clicked = true;
    }

}
