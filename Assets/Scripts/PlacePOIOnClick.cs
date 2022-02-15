using Mapbox.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacePOIOnClick : MonoBehaviour
{
    [SerializeField]
    private GameObject Map;

    // Start is called before the first frame update
    void Start()
    {
        if (Map != null)
        {
            Map.GetComponent<SpawnOnMap>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
