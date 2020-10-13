﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmartnessScript : MonoBehaviour
{

    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = FindObjectOfType<ScoreScript>().brainScore / 10.0f;
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
