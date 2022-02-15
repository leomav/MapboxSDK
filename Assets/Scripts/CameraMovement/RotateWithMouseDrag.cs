using UnityEngine;

public class RotateWithMouseDrag : MonoBehaviour
{

    public float Speed = 5;

    [SerializeField]
    private bool invertVerticalLook = false;

    [SerializeField]
    private bool lockYAxis = false;

    [SerializeField]
    private bool lockXAxis = false;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var invert = invertVerticalLook ? -1 : 1;
            var lockYaxis = lockYAxis ? 0 : 1;
            var lockXaxis = lockXAxis ? 0 : 1;

            transform.eulerAngles -= Speed * new Vector3(invert * lockYaxis * Input.GetAxis("Mouse Y"), lockXaxis * Input.GetAxis("Mouse X"), 0);

            //transform.Rotate(transform.up ,-Input.GetAxis("Mouse X") * Speed  ); //1
        }
    }
}