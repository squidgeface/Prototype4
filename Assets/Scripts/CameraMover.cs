using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMover : MonoBehaviour
{
    public bool activated = false;
    public bool fade = false;
    public float speed = 0.01f;

    // Update is called once per frame
    void Update()
    {
        if (activated)
        {
            gameObject.transform.position += new Vector3(0.0f, 0.0f, speed);
        }
        
        if (gameObject.transform.position.z >= 0.0f)
        {
            activated = false;
            fade = true;
            SceneManager.LoadScene(2);
        }
    }
}
