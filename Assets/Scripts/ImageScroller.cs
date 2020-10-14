using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageScroller : MonoBehaviour
{
      // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(-1 * Time.deltaTime * 100, 0.0f, 0.0f);

        if (gameObject.transform.position.x <= -(Screen.width/2.0f))
        {
            gameObject.transform.position = new Vector3(Screen.width + ((Screen.width / 2.0f)), gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
}
