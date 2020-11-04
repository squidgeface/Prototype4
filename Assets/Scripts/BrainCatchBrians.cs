using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;

public class BrainCatchBrians : MonoBehaviour
{
    string fullText;
    public TextMeshPro text;
    // Update is called once per frame

    private void Start()
    {
        float randText = Random.Range(1, 6);
        if(randText == 1)
        {
            fullText = "CLIMATE CHANGE";
        }
        else if (randText == 2)
        {
            fullText = "PANDEMIC";
        }
        else if (randText == 3)
        {
            fullText = "VOTER FRAUD";
        } 
        else if (randText == 4)
        {
            fullText = "MILITARY BUDGET";
        } 
        else if (randText == 5)
        {
            fullText = "SPACE FORCE";
        }

        text.GetComponent<TextMeshPro>().text = fullText;
    }
    void Update()
    {
        transform.position -= new Vector3(0.0f, FindObjectOfType<BrainCatching>().speed * Time.deltaTime, 0.0f);
    }


    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<ScoreScript>().brainScore -= 1;
        //FindObjectOfType<BrainCatching>().score.text = FindObjectOfType<ScoreScript>().brainScore.ToString() + "/10";
        float pitch = Random.Range(0.9f, 1.1f);
        FindObjectOfType<brainFart>().squish.pitch = pitch;
        FindObjectOfType<brainFart>().squish.Play();
        GameObject.Destroy(this.gameObject);
    }
}
