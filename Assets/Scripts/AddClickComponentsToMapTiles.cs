using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddClickComponentsToMapTiles : MonoBehaviour
{
    [SerializeField]
    private bool addClick = true;
    [SerializeField]
    private bool addDoubleClick = true;

    // Start is called before the first frame update
    void Start()
    {
        if (addClick)
        {
            AddClickToTiles();
        }

        if (addDoubleClick)
        {
            AddDoubleClickToTiles();
        }
    }


    void AddClickToTiles()
    {
        while (true)
        {
            int count = 0;

            foreach (Transform child in transform)
            {
                count++;
                child.gameObject.AddComponent<ClickOnMap>();
            }

            if (count > 0)
            {
                break;
            }
        }

    }

    void AddDoubleClickToTiles()
    {
        while (true)
        {
            int count = 0;

            foreach (Transform child in transform)
            {
                count++;
                child.gameObject.AddComponent<DoubleClick>();
            }

            if (count > 0)
            {
                break;
            }
        }

    }
}
