using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCatcher : MonoBehaviour
{
    public float speed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(Time.deltaTime * speed, 0, 0);
        }
    }
}
