using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Movement WASD | Arrows
/// Place this script on the Player Camera (or Main Camera) to simulate
/// player movement around the map.
/// the camera around the scene and navigate through space.
/// </summary>
public class MoveForwardPlayer : MonoBehaviour
{
    private float m_Speed = 20;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            // Move Player forward at z axis 1 unit/sec;
            transform.Translate(Vector3.forward * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //Rotate the sprite about the Y axis in the positive direction
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * m_Speed, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //Rotate the sprite about the Y axis in the negative direction
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * m_Speed, Space.World);
        }
    }


}
