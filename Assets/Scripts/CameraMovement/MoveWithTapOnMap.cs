using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithTapOnMap : MonoBehaviour
{
    private Vector3 targetPos;

    private Vector3 targetPosWithAltitude;

    private bool moveCameraToPoint = false;

    private float newCameraY;

    [SerializeField]
    private float rotateSpeed = 5;
    [SerializeField]
    private float moveSpeed = 5;

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

            // Rotate Towards Target
            Quaternion rotTarget = Quaternion.LookRotation(targetPos - transform.position);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotTarget, rotateSpeed * Time.deltaTime);

            // Move Towards Target
            transform.position = Vector3.MoveTowards(transform.position, targetPosWithAltitude, moveSpeed * Time.deltaTime);

            var delta = targetPosWithAltitude - transform.position;
            print(delta);

            // Exit Check
            if (Quaternion.Angle(rotTarget, transform.rotation) < 0.1f)
                /*&& targetPosWithAltitude - transform.position < new Vector3(0.1f,0.1f,0.1f)*/
            {
                moveCameraToPoint = false;
            }
        }
        
    }

    private void CameraMoveToPoint(Vector3 mousePos)
    {
        moveCameraToPoint = true;
        targetPos = mousePos;
        newCameraY = targetPos.y + transform.position.y;
        targetPosWithAltitude = new Vector3(targetPos.x, newCameraY, targetPos.z);

    }

}
