using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHeightWithWheel : MonoBehaviour
{
    [SerializeField]
    private float ScrollSpeed = 10;


    void Update()
    {
        transform.Translate(Vector3.down * Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed);
    }
}
