using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frumpBlink : MonoBehaviour
{
    public Camera camera;

    // Update is called once per frame
    void Update()
    {
        if (camera.transform.position.z < -10.0f)
        {
            gameObject.GetComponent<Renderer>().materials[0].CopyPropertiesFromMaterial(gameObject.GetComponent<Renderer>().materials[1]);
        }
    }
}
