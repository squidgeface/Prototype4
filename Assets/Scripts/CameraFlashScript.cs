using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CameraFlashScript : MonoBehaviour
{
    public float delay = 50.0f;
    float counter = 0f;

    private void Start()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    private void Update()
    {
        if (counter == delay)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
        if (counter == delay + 5.0f)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            counter = 0;
        }

        counter++;
    }



}
