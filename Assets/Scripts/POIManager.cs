using System;
using UnityEngine;

public class POIManager : MonoBehaviour
{
    public static POIManager current;
    private Vector3 mousePos;
    private Vector3 worldMousePos;

    public Vector3 GetMousePosition()
    {
        return worldMousePos;
    }

    private void Awake()
    {
        current = this;
    }

    public event Action<Vector3> onMapDoubleClicked;
    public event Action onMapClicked;

    public void MapClicked()
    {
        // Invoke Event for observers
        if (onMapClicked != null)
        {
            onMapClicked();
        }
        //print("Map Clicked");
    }

    public void MapDoubleClicked()
    {
        print("Map Double Clicked");

        // Get mouse position and convert it to 3D Space
        GetMousePositionToWorldSpace();

        // Invoke Event for observers
        if (onMapDoubleClicked != null && worldMousePos != null)
        {
            onMapDoubleClicked(worldMousePos);
        }



    }

    private void GetMousePositionToWorldSpace()
    {
        mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        worldMousePos = Camera.main.ScreenToWorldPoint(mousePos);
    }


}
