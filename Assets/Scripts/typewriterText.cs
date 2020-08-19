using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class typewriterText : MonoBehaviour
{
    public float delay = 0.5f;
    public string fullText;
    private string curText = "";
    public bool startText = false;
    public bool clicked = false;

    private void Update()
    {
        if (startText)
        {
            StartCoroutine(RevealText());
            startText = false;
            clicked = false;
        }
    }

    private IEnumerator RevealText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            curText = fullText.Substring(0, i);
            this.GetComponent<TextMeshPro>().text = curText;
            yield return new WaitForSeconds(delay);
        }
    }

    void OnMouseDown()
    {
        if (!clicked)
            clicked = true;
    }


}
