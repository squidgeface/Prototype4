using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class levelScript : MonoBehaviour
{
    public int level = 0;
    public int response = 0;

    public bool Clicked = false;


    private void Update()
    {
        response = FindObjectOfType<ScoreScript>().response;
        level = FindObjectOfType<ScoreScript>().level;
    }

    public void Click()
    {
        Clicked = true;
    }

}
