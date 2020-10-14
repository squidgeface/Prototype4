using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmartnessScript : MonoBehaviour
{

    public Slider slider;
    public float divider = 10.0f;

    // Update is called once per frame
    void Update()
    {
        slider.value = FindObjectOfType<ScoreScript>().brainScore / divider;
    }

    public void setSmart(float smart)
    {
        slider.value = smart;
    }

    public float getSmart()
    {
        return (slider.value);
    }
}
