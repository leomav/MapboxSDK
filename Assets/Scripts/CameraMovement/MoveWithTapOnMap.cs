using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithTapOnMap : MonoBehaviour
{
    private Vector3 targetPos;

    private bool moveCameraToPoint = false;

    [SerializeField]
    private float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        POIManager.current.onMapDoubleClicked += CameraMoveToPoint;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveCameraToPoint)
        {

            // Rotate Towards
            Quaternion rotTarget = Quaternion.LookRotation(targetPos - transform.position);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotTarget, speed * Time.deltaTime);

            if (Quaternion.Angle(rotTarget, transform.rotation) < 0.1f){
                moveCameraToPoint = false;
            }
        }
        
    }

    private void CameraMoveToPoint(Vector3 mousePos)
    {
        moveCameraToPoint = true;
        targetPos = mousePos;

    }

}
