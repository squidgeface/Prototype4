using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeScript : MonoBehaviour
{
    public float speed = 255.0f;
    Color tempMat;

    private void Start()
    {
        tempMat = gameObject.GetComponent<MeshRenderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        speed -= 0.001f;
        tempMat.a = speed;
        gameObject.GetComponent<MeshRenderer>().material.color = tempMat;
    }
}
