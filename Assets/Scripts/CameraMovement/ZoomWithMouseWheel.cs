using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomWithMouseWheel : MonoBehaviour
{
    [SerializeField]
    private float ScrollSpeed = 10;

    private Camera ZoomCamera;

    void Start()
    {
        ZoomCamera = Camera.main;
    }

    void Update()
    {

        //ZoomCamera.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;


        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit point;
            Physics.Raycast(ray, out point, 25);
            Vector3 Scrolldirection = ray.GetPoint(5);

            float step = ScrollSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Scrolldirection, Input.GetAxis("Mouse ScrollWheel") * step);
        }

    }



}
