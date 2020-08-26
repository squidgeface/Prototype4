using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMover : MonoBehaviour
{
    public bool activated = false;
    public bool fade = false;
    public float speed = 0.01f;
    public int level = 0;
    public levelScript LevelManager;
    public TrumpWriterText trumpSpeak;


    // Update is called once per frame
    void Update()
    {
        level = LevelManager.GetComponent<levelScript>().level;
        

        if (level == 0)
        {
            if (activated)
            {
                gameObject.transform.position += new Vector3(0.0f, 0.0f, speed * Time.deltaTime * 150.0f);

                if (gameObject.transform.position.z >= 0.0f)
                {
                    activated = false;
                    fade = true;
                    SceneManager.LoadScene(2);
                }
            }

            
        }
        else if (level == 1)
        {
            if (!activated)
            {
                gameObject.transform.position += new Vector3(0.0f, 0.0f, -speed * Time.deltaTime * 150.0f);

                if (gameObject.transform.position.z <= -20.0f)
                {
                    activated = true;

                    trumpSpeak.GetComponent<TrumpWriterText>().startText = true;
                    trumpSpeak.GetComponent<TrumpWriterText>().isPlaying = true;

                }
            }
        }
        else if (level == 3)
        {
            if (activated)
            {
                gameObject.transform.position += new Vector3(0.0f, 0.0f, speed * Time.deltaTime * 150.0f);

                if (gameObject.transform.position.z >= 0.0f)
                {
                    activated = false;
                    fade = true;
                    SceneManager.LoadScene(2);
                }
            }


        }
        else if (level == 4)
        {
            if (!activated)
            {
                gameObject.transform.position += new Vector3(0.0f, 0.0f, -speed * Time.deltaTime * 150.0f);

                if (gameObject.transform.position.z <= -20.0f)
                {
                    activated = true;

                    trumpSpeak.GetComponent<TrumpWriterText>().startText = true;
                    trumpSpeak.GetComponent<TrumpWriterText>().isPlaying = true;

                }
            }
        }
        else if (level == 6)
        {
            if (activated)
            {
                gameObject.transform.position += new Vector3(0.0f, 0.0f, speed * Time.deltaTime * 150.0f);

                if (gameObject.transform.position.z >= 0.0f)
                {
                    activated = false;
                    fade = true;
                    SceneManager.LoadScene(2);
                }
            }


        }
        else if (level == 7)
        {
            if (!activated)
            {
                gameObject.transform.position += new Vector3(0.0f, 0.0f, -speed * Time.deltaTime * 150.0f);

                if (gameObject.transform.position.z <= -20.0f)
                {
                    activated = true;

                    trumpSpeak.GetComponent<TrumpWriterText>().startText = true;
                    trumpSpeak.GetComponent<TrumpWriterText>().isPlaying = true;

                }
            }
        }
    }
}
