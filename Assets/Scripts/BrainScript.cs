using System.Collections;
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

    public float  speed;

    public AudioSource sound1;
    public AudioSource sound2;
    public AudioSource sound3;

    public GameObject bar;


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
        speed = Random.Range(0.5f, 2.0f);
        FindObjectOfType<brainFart>().swoosh.Play();

    }

    // Update is called once per frame
    void Update()
    {

        int random = Random.RandomRange(0, 2000);
        if (random == 1 || random == 4 || random == 5)
        {
            if (!sound1.isPlaying)
                sound1.Play();
        }
        if (random == 2)
        {
            if (!sound2.isPlaying)
                sound2.Play();
        }
        if (random == 3)
        {
            if (!sound3.isPlaying)
                sound3.Play();
        }

        //move towards the target
        me.transform.Rotate(0, 0, 1);
        transform.position -= moveTowards * Time.deltaTime * 8 * speed;

        
        //count how long minigame has been going ~26 is end of game in this example
        timer += Time.deltaTime;

        if (timer > 28.0f)
        {
            //END MINI GAME AND GOTO NEXT SCENE

            if (FindObjectOfType<ScoreScript>().game1 == -1)
            {
                FindObjectOfType<ScoreScript>().game1 = FindObjectOfType<ScoreScript>().brainScore;
                FindObjectOfType<ScoreScript>().level++;
                if (FindObjectOfType<ScoreScript>().brainScore > 0 && FindObjectOfType<ScoreScript>().brainScore < 4)
                {
                    FindObjectOfType<ScoreScript>().response = 3;
                }
                else if (FindObjectOfType<ScoreScript>().brainScore > 3 && FindObjectOfType<ScoreScript>().brainScore < 8)
                {
                    FindObjectOfType<ScoreScript>().response = 2;
                }
                else if (FindObjectOfType<ScoreScript>().brainScore > 7 && FindObjectOfType<ScoreScript>().brainScore < 10)
                {
                    FindObjectOfType<ScoreScript>().response = 1;
                }
                else if (FindObjectOfType<ScoreScript>().brainScore == 0)
                {
                    FindObjectOfType<ScoreScript>().response = 4;
                }

            } else if (FindObjectOfType<ScoreScript>().game2 == -1)
            {
                FindObjectOfType<ScoreScript>().game2 = FindObjectOfType<ScoreScript>().brainScore;
                FindObjectOfType<ScoreScript>().level++;
                if (FindObjectOfType<ScoreScript>().brainScore > 0 && FindObjectOfType<ScoreScript>().brainScore < 4)
                {
                    FindObjectOfType<ScoreScript>().response = 3;
                }
                else if (FindObjectOfType<ScoreScript>().brainScore > 3 && FindObjectOfType<ScoreScript>().brainScore < 8)
                {
                    FindObjectOfType<ScoreScript>().response = 2;
                }
                else if (FindObjectOfType<ScoreScript>().brainScore > 7 && FindObjectOfType<ScoreScript>().brainScore < 10)
                {
                    FindObjectOfType<ScoreScript>().response = 1;
                }
                else if (FindObjectOfType<ScoreScript>().brainScore == 0)
                {
                    FindObjectOfType<ScoreScript>().response = 4;
                }
            }
            else if (FindObjectOfType<ScoreScript>().game3 == -1)
            {
                FindObjectOfType<ScoreScript>().game3 = FindObjectOfType<ScoreScript>().brainScore;
                FindObjectOfType<ScoreScript>().level++;
                if (FindObjectOfType<ScoreScript>().brainScore > 0 && FindObjectOfType<ScoreScript>().brainScore < 4)
                {
                    FindObjectOfType<ScoreScript>().response = 3;
                }
                else if (FindObjectOfType<ScoreScript>().brainScore > 3 && FindObjectOfType<ScoreScript>().brainScore < 8)
                {
                    FindObjectOfType<ScoreScript>().response = 2;
                }
                else if (FindObjectOfType<ScoreScript>().brainScore > 7 && FindObjectOfType<ScoreScript>().brainScore < 10)
                {
                    FindObjectOfType<ScoreScript>().response = 1;
                }
                else if (FindObjectOfType<ScoreScript>().brainScore == 0)
                {
                    FindObjectOfType<ScoreScript>().response = 4;
                }
            }


            FindObjectOfType<ScoreScript>().brainScore = 0;

            if (FindObjectOfType<ScoreScript>().level == 1)
            {
                SceneManager.LoadScene(3);
            }
            else if (FindObjectOfType<ScoreScript>().level == 3)
            {
                SceneManager.LoadScene(5);
            }
            else if (FindObjectOfType<ScoreScript>().level == 5)
            {
                SceneManager.LoadScene(7);
            }
           


        }
    }
    private void OnMouseDown()
    {
        //destroy and add to score when clicked
       


        FindObjectOfType<ScoreScript>().brainScore += 1;
      // bar.GetComponent<SmartnessScript>().setSmart(FindObjectOfType<ScoreScript>().brainScore / 10);
      // float bob = bar.GetComponent<SmartnessScript>().getSmart();
        score.text = FindObjectOfType<ScoreScript>().brainScore.ToString() + "/ 10";
        FindObjectOfType<brainFart>().squish.Play();
        GameObject.Destroy(me, 0);
    }

}

