using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScroller : MonoBehaviour
{
    public float speed = 1.0f;
      // Update is called once per frame
    void Update()
    {
        //gameObject.GetComponent<RectTransform>().rect.x += new Vector3(-speed * Time.deltaTime * 100, 0.0f, 0.0f);
        gameObject.GetComponent<RectTransform>().localPosition += new Vector3(-speed * Time.deltaTime * 100, 0.0f, 0.0f);

    }
}
