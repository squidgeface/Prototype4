using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainCatchBrians : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0.0f, FindObjectOfType<BrainCatching>().speed * Time.deltaTime, 0.0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<ScoreScript>().brainScore += 1;
        FindObjectOfType<BrainCatching>().score.text = FindObjectOfType<ScoreScript>().brainScore.ToString() + "/ 10";
        FindObjectOfType<brainFart>().squish.Play();
        GameObject.Destroy(this.gameObject, 0);
    }
}
