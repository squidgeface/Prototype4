using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrumpMover : MonoBehaviour
{
    public float moveSpeed = 30.0f;
    int horizontal = 0;
    int vertical = 0;
    public int brainCount = 0;
    public AudioSource splat;
    public AudioSource Music;
    public Image image;
    Color c;
    public Canvas canvas;

    private void Start()
    {
        c = image.color;
        tempTrails = gameObject.GetComponentInChildren<ParticleSystem>().GetTrails();
        oldTrails = new ParticleSystem.Trails();
    }

    private void Update()
    {
        MovePlayer();

        if (brainCount == 10)
        {
            FindScore();
            brainCount++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FlyingBrain")
        {
            brainCount++;
            FindObjectOfType<ScoreScript>().brainScore += 1;
            Destroy(other.gameObject);
            splat.Play();
        }
    }

    private void MovePlayer()
    {
        float width = canvas.gameObject.GetComponent<RectTransform>().rect.width;
        float height = canvas.gameObject.GetComponent<RectTransform>().rect.height;

        gameObject.GetComponent<RectTransform>().localPosition = new Vector3(gameObject.GetComponent<RectTransform>().localPosition.x + moveSpeed * horizontal * Time.deltaTime * 100.0f, gameObject.GetComponent<RectTransform>().localPosition.y + moveSpeed * vertical * Time.deltaTime * 100.0f, gameObject.GetComponent<RectTransform>().localPosition.z);
        
        float offset = 50.0f;
        if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && gameObject.GetComponent<RectTransform>().localPosition.y > (-height / 2) + offset)
        {
            vertical = -1;
        }
        else if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && gameObject.GetComponent<RectTransform>().localPosition.y < (height / 2) - offset)
        {
            vertical = 1;
        }
        else
        {
            vertical = 0;
        }

        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && gameObject.GetComponent<RectTransform>().localPosition.x > (-width/2) + offset)
        {
            horizontal = -1;
        }
        else if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && gameObject.GetComponent<RectTransform>().localPosition.x < (width / 2) - offset)
        {
            horizontal = 1;
        }
        else
        {
            horizontal = 0;
        }

        
    }


    private void FindScore()
    {
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
            else if (FindObjectOfType<ScoreScript>().brainScore > 7 && FindObjectOfType<ScoreScript>().brainScore <= 10)
            {
                FindObjectOfType<ScoreScript>().response = 1;
            }
            else if (FindObjectOfType<ScoreScript>().brainScore == 0)
            {
                FindObjectOfType<ScoreScript>().response = 4;
            }

        }
        else if (FindObjectOfType<ScoreScript>().game2 == -1)
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
            else if (FindObjectOfType<ScoreScript>().brainScore > 7 && FindObjectOfType<ScoreScript>().brainScore <= 10)
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
        StartCoroutine(FadeOut());


    }

    public IEnumerator FadeOut()
    {
        StartCoroutine(FadeOutMusic(Music, 5));

        yield return new WaitForSeconds(5);

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

        yield return null;
    }

    public IEnumerator FadeOutMusic(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;
        float adjustedVolume = startVolume;

        while (audioSource.volume > 0)
        {
            adjustedVolume -= startVolume * Time.deltaTime / FadeTime;
            audioSource.volume = adjustedVolume;
            if (c.a <= 1)
            {
                c.a += 0.2f * Time.deltaTime;
                image.color = c;
            }
            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = startVolume;
    }

}
