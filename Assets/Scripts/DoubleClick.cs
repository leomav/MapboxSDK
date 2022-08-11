using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleClick : MonoBehaviour
{
    public float clickDelta = 0.35f;  // Max between two click to be considered a double click

    private bool click = false;
    private float clickTime;

    void Update()
    {
        // Probably Drag, no double click
        if (click && Time.time > (clickTime + clickDelta))
        {
            click = false;
        }
    }

    void OnMouseDown()
    {
        // Second click --> Double Click
        if (click && Time.time <= (clickTime + clickDelta))
        {
            DoDoubleClick();
            click = false;
        }
        // First click
        else
        {
            click = true;
            clickTime = Time.time;
        }
    }

    void DoDoubleClick()
    {
    }
}
