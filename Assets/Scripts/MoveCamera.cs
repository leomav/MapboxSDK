using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Movement WASD | Arrows
/// Place this script on the Player Camera (or Main Camera) to move
/// the camera around the scene and navigate through space.
/// </summary>
public class MoveCamera : MonoBehaviour
{
    [SerializeField]
    private float m_Speed = 5;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            // Move Camera forwards 1 unit/sec;
            transform.Translate(Vector3.forward * Time.deltaTime * m_Speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            // Move Camera right 1 unit/sec;
            transform.Translate(Vector3.right * Time.deltaTime * m_Speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            // Move Camera left 1 unit/sec;
            transform.Translate(Vector3.left * Time.deltaTime * m_Speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            // Move Camera backwards unit/sec;
            transform.Translate(Vector3.back * Time.deltaTime * m_Speed);
        }
    }


}
