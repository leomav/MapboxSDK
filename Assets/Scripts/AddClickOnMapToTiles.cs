using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddClickOnMapToTiles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AddComponentToTiles();
    }


    void AddComponentToTiles()
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
}
