using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrumpMover : MonoBehaviour
{
    public float moveSpeed = 30.0f;
    int horizontal = 0;
    int vertical = 0;

    private void Update()
    {
        if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && gameObject.GetComponent<RectTransform>().position.y > 0.0f)
        {
            vertical = -1;
        }
        else if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && gameObject.GetComponent<RectTransform>().position.y < Screen.height)
        {
            vertical = 1;
        }
        else
        {
            vertical = 0;
        }

        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && gameObject.GetComponent<RectTransform>().position.x > 0.0f)
        {
            horizontal = -1;
        }
        else if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && gameObject.GetComponent<RectTransform>().position.x < Screen.width)
        {
            horizontal = 1;
        }
        else
        {
            horizontal = 0;
        }
        MovePlayer();
    }

    private void MovePlayer()
    {
        gameObject.GetComponent<RectTransform>().position = new Vector3(gameObject.GetComponent<RectTransform>().position.x + moveSpeed * horizontal * Time.deltaTime * 100.0f, gameObject.GetComponent<RectTransform>().position.y + moveSpeed * vertical * Time.deltaTime * 100.0f, 0.0f);
    }
}
