using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int GoodScore = 0;
    public int StupidScore = 0;
    public int EvilScore = 0;

 

    void Start()
    {
        Object.DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        if (GoodScore >= 2)
        {
            GoodEnding();
        } else if (StupidScore >= 2)
        {
            StupidEnding();
        }else if(EvilScore >= 2)
        {
            EvilEnding();
        }
        else
        {
            StupidEnding();
        }
    }

    public void GoodEnding()
    {
        //goto good scene
    }
    public void StupidEnding()
    {
        //goto stupid scene
    }
    public void EvilEnding()
    {
        //goto Evil scene
    }
}
