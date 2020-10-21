using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BrainCatching : MonoBehaviour
{
    public GameObject brain;
    float counter = 0;
    int BrainCounter = 0;
    public Text score;

    public float  speed;

    public AudioSource sound1;
    public AudioSource sound2;
    public AudioSource sound3;


    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        //target = GameObject.Find("Target");


        // objectRotation = Vector3.RotateTowards(transform.position, target.transform.position, 2 * Mathf.PI, 10);
        //me.transform.rotation = new Quaternion();
      
      //  transform.RotateAround(target.transform.position, Random.Range(0, 360));

        //find the direction of the target
        //moveTowards = Vector3.MoveTowards(this.transform.position, target.transform.position, 0.1f);
        //moveTowards.z = 0;
        //moveTowards.Normalize();
        //speed = Random.Range(0.5f, 2.0f);
        //FindObjectOfType<brainFart>().swoosh.Play();

    }

    // Update is called once per frame
    void Update()
    {
        counter += 1 * Time.deltaTime * 100;

        if (counter >= 200 && BrainCounter <= 9)
        {
            float randomX = Random.Range(-4.0f, 4.0f);
            Instantiate(brain, new Vector3(randomX, 15.0f, 0.0f), new Quaternion());
            BrainCounter++;

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

            counter = 0;
        }
        
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
            else if (FindObjectOfType<ScoreScript>().game4 == -1)
            {
                FindObjectOfType<ScoreScript>().game4 = FindObjectOfType<ScoreScript>().brainScore;
                FindObjectOfType<ScoreScript>().level++;
                if (FindObjectOfType<ScoreScript>().brainScore > 0 && FindObjectOfType<ScoreScript>().brainScore < 4)
                {
                    FindObjectOfType<ScoreScript>().response = 3;
                }
                else if (FindObjectOfType<ScoreScript>().brainScore > 3 && FindObjectOfType<ScoreScript>().brainScore < 8)
                {
                    FindObjectOfType<ScoreScript>().response = 2;
                }
                else if (FindObjectOfType<ScoreScript>().brainScore > 7 && FindObjectOfType<ScoreScript>().brainScore <= 10)
                {
                    FindObjectOfType<ScoreScript>().response = 1;
                }
                else if (FindObjectOfType<ScoreScript>().brainScore == 0)
                {
                    FindObjectOfType<ScoreScript>().response = 4;
                }
            }
            else if (FindObjectOfType<ScoreScript>().game5 == -1)
            {
                FindObjectOfType<ScoreScript>().game5 = FindObjectOfType<ScoreScript>().brainScore;
                FindObjectOfType<ScoreScript>().level++;
                if (FindObjectOfType<ScoreScript>().brainScore > 0 && FindObjectOfType<ScoreScript>().brainScore < 4)
                {
                    FindObjectOfType<ScoreScript>().response = 3;
                }
                else if (FindObjectOfType<ScoreScript>().brainScore > 3 && FindObjectOfType<ScoreScript>().brainScore < 8)
                {
                    FindObjectOfType<ScoreScript>().response = 2;
                }
                else if (FindObjectOfType<ScoreScript>().brainScore > 7 && FindObjectOfType<ScoreScript>().brainScore <= 10)
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
                SceneManager.LoadScene(5);
            }
            else if (FindObjectOfType<ScoreScript>().level == 3)
            {
                SceneManager.LoadScene(7);
            }
            else if (FindObjectOfType<ScoreScript>().level == 5)
            {
                SceneManager.LoadScene(9);
            }
            else if (FindObjectOfType<ScoreScript>().level == 7)
            {
                SceneManager.LoadScene(11);
            }
            else if (FindObjectOfType<ScoreScript>().level == 9)
            {
                SceneManager.LoadScene(13);
            }
        }
    }
}

