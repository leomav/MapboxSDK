using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnMap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    var hit: RaycastHit;
        //    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    if (Physics.Raycast(ray, hit))
        //    {
        //        if (hit.transform.name == "MyObjectName") Debug.Log("My object is clicked by mouse");
        //    }
        //}


    }

    private void OnMouseDown()
    {
        print("Map clicked.");
    }

    private void OnMouseUpAsButton()
    {
        print("Mouse up as button");
    }
}

