using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class levelScript : MonoBehaviour
{
 
    public GameObject Dialogue1;
    public GameObject Dialogue2;
    public GameObject Dialogue3;
 

    bool activateDialogue = false;

    // Update is called once per frame
    void Update()
    {
        if (Dialogue1.GetComponent<typewriterText>().clicked)
        {
            Dialogue1.GetComponent<typewriterText>().startText = true;
        }
        else if (Dialogue2.GetComponent<typewriterText>().clicked)
        {
            Dialogue2.GetComponent<typewriterText>().startText = true;
        }
        else if (Dialogue3.GetComponent<typewriterText>().clicked)
        {
            Dialogue3.GetComponent<typewriterText>().startText = true;
        }

    }

}
