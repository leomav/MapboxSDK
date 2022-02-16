using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotationAxis : MonoBehaviour
{
    [SerializeField]
    private bool LockX;
    [SerializeField]
    private bool LockY;
    [SerializeField]
    private bool LockZ;

    private float lockX;
    private float lockY;
    private float lockZ;

    private Transform t;

    // Start is called before the first frame update
    void Start()
    {
        t = transform;
    }

    // Update is called once per frame
    void Update()
    {
        lockX = LockX ? 0 : 1;
        lockY = LockY ? 0 : 1;
        lockZ = LockZ ? 0 : 1;

        t.eulerAngles = new Vector3(lockX * t.eulerAngles.x, lockY * t.eulerAngles.y, lockZ * t.eulerAngles.z);
    }
}
