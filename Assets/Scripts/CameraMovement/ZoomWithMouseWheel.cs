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

        ZoomCamera.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
    }
}
