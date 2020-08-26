﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BrainScript : MonoBehaviour

{

    public GameObject target;
    public GameObject me;
    private Vector3 objectRotation;
    private Vector3 moveTowards;
    public Text score;

    public AudioSource sound1;
    public AudioSource sound2;
    public AudioSource sound3;


    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Target");


        // objectRotation = Vector3.RotateTowards(transform.position, target.transform.position, 2 * Mathf.PI, 10);
        me.transform.rotation = new Quaternion();
      
      //  transform.RotateAround(target.transform.position, Random.Range(0, 360));

        //find the direction of the target
        moveTowards = Vector3.MoveTowards(this.transform.position, target.transform.position, 0.1f);
        moveTowards.z = 0;
        moveTowards.Normalize();
        
    }

    // Update is called once per frame
    void Update()
    {

        int random = Random.RandomRange(0, 2000);
        if (random == 1 || random == 4 || random == 5)
        {
            sound1.Play();
        }
        if (random == 2)
        {
            sound2.Play();
        }
        if (random == 3)
        {
            sound3.Play();
        }

        //move towards the target
        me.transform.Rotate(0, 0, 1);
        transform.position -= moveTowards * Time.deltaTime * 8;

        
        //count how long minigame has been going ~26 is end of game in this example
        timer += Time.deltaTime;

        if (timer > 26.5f)
        {
            //END MINI GAME AND GOTO NEXT SCENE

            if (FindObjectOfType<ScoreScript>().game1 == -1)
            {
                FindObjectOfType<ScoreScript>().game1 = FindObjectOfType<ScoreScript>().brainScore;

            } else if (FindObjectOfType<ScoreScript>().game2 == -1)
            {
                FindObjectOfType<ScoreScript>().game2 = FindObjectOfType<ScoreScript>().brainScore;
            }
            else if (FindObjectOfType<ScoreScript>().game3 == -1)
            {
                FindObjectOfType<ScoreScript>().game3 = FindObjectOfType<ScoreScript>().brainScore;
            }


            FindObjectOfType<ScoreScript>().brainScore = 0;


            SceneManager.LoadScene(3);



        }
    }
    private void OnMouseDown()
    {
        //destroy and add to score when clicked
       
        FindObjectOfType<ScoreScript>().brainScore += 1;
        score.text = FindObjectOfType<ScoreScript>().brainScore.ToString() + "/ 10";
        GameObject.Destroy(me, 0);
    }

}

