using Mapbox.Unity.Map;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToClick : MonoBehaviour
{
    private Vector3 targetPos;

    private Vector3 targetPosWithAltitude;

    private bool moveCameraToPoint = false;

    private float newCameraY;

    // Lerp: High speed - Faster
    // SmoothDamp: High speed - Slower
    [SerializeField]
    private float rotateSpeed = 5;
    [SerializeField]
    private float moveSpeed = 60;

    [SerializeField]
    private Camera usedCamera;

    float distance;

    [SerializeField]
    AbstractMap _map;

    // Start is called before the first frame update
    void Start()
    {
        if (usedCamera == null)
        {
            usedCamera = Camera.main;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (moveCameraToPoint)
        {

            // Rotate Towards Target
            Quaternion containerRotTarget = Quaternion.LookRotation(targetPos - transform.position);
            Quaternion cameraRotTarget = Quaternion.LookRotation(targetPos - transform.position);
            containerRotTarget.eulerAngles = new Vector3(transform.rotation.eulerAngles.x, containerRotTarget.eulerAngles.y, transform.rotation.eulerAngles.z);
            cameraRotTarget.eulerAngles = new Vector3(cameraRotTarget.eulerAngles.x, transform.rotation.eulerAngles.y, usedCamera.transform.rotation.eulerAngles.z);
            transform.rotation = Quaternion.Lerp(transform.rotation, containerRotTarget, rotateSpeed * Time.deltaTime);
            usedCamera.transform.rotation = Quaternion.Lerp(usedCamera.transform.rotation, cameraRotTarget, rotateSpeed * Time.deltaTime);

            // Move Towards Target
            if (distance > 20)
            {
                var velocity = Vector3.zero;
                transform.position = Vector3.SmoothDamp(transform.position, targetPosWithAltitude, ref velocity, moveSpeed * Time.deltaTime);
                distance = Vector3.Distance(transform.position, targetPosWithAltitude);
            }


            // Exit Check
            if (Quaternion.Angle(containerRotTarget, transform.rotation) < 0.1f && Quaternion.Angle(cameraRotTarget, usedCamera.transform.rotation) < 0.1f && distance <= 20)
            {
                moveCameraToPoint = false;
            }
        }

    }

    private void CameraMoveToPoint(Vector3 mousePos)
    {
        print(_map.WorldToGeoPosition(mousePos));

        moveCameraToPoint = true;
        targetPos = mousePos;
        newCameraY = 10 + targetPos.y;
        targetPosWithAltitude = new Vector3(targetPos.x, newCameraY, targetPos.z);
        distance = 100000000;

    }

}
