using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnMap : MonoBehaviour
{

    [SerializeField]
    private float ClickDeltaTime = 0.2f;

    private float downClickTime;
    private bool isClicked;


    private void OnMouseDown()
    {
        downClickTime = Time.time;
    }

    private void OnMouseUp()
    {

        isClicked = Time.time - downClickTime <= ClickDeltaTime ? true : false;

        if (isClicked)
        {
           
            POIManager.current.MapClicked();
        }

    }


}

