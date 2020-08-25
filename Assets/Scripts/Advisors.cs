using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Advisors : MonoBehaviour
{
    public int advisorNum = 0;
    public bool clicked = false;

    private void OnMouseDown()
    {
        clicked = true;
    }
}
