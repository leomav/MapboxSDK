using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHeightWithWheel : MonoBehaviour
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

        ZoomCamera.transform.Translate(Vector3.down * Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed);

    }
}
