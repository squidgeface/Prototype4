using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCatcher : MonoBehaviour
{
    public float speed = 100.0f;

    private void Start()
    {
        FindObjectOfType<ScoreScript>().brainScore = 10;
        //FindObjectOfType<BrainCatching>().score.text = FindObjectOfType<ScoreScript>().brainScore.ToString() + "/10";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 5)
            {
                transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -5)
            {
                transform.position -= new Vector3(Time.deltaTime * speed, 0, 0);
            }
        }
    }
}
