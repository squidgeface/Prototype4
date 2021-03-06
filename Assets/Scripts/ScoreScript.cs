﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int GoodScore = 0;
    public int StupidScore = 0;
    public int EvilScore = 0;

    public int brainScore = 0;

    public int game1 = -1;
    public int game2 = -1;
    public int game3 = -1;
    public int game4 = -1;
    public int game5 = -1;

    public int response = 0;
    public int level = 0;


    private ScoreScript[] EventSystems;

    void Start()
    {
        EventSystems = FindObjectsOfType<ScoreScript>();

        if (EventSystems.Length > 1)
        {
            Destroy(this.gameObject);
        }

        Object.DontDestroyOnLoad(this);
    }

    public void EndGame()
    {
        if (GoodScore >= 4)
        {
            GoodEnding();
        } else if (StupidScore >= 4)
        {
            StupidEnding();
        }else if(EvilScore >= 4)
        {
            EvilEnding();
        }
        else
        {
            PerfectEnding();
        }
    }

    public void PerfectEnding()
    {
        FindObjectOfType<ScoreScript>().response = 4;

    }
    public void GoodEnding()
    {
        FindObjectOfType<ScoreScript>().response = 3;

    }
    public void StupidEnding()
    {
        //goto stupid scene
        FindObjectOfType<ScoreScript>().response = 2;
    }
    public void EvilEnding()
    {
        //goto Evil scene
        FindObjectOfType<ScoreScript>().response = 1;
    }
}
