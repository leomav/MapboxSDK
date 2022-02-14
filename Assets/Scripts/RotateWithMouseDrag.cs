using UnityEngine;

public class RotateWithMouseDrag : MonoBehaviour
{

    public float Speed = 5;

    [SerializeField]
    private bool invertVerticalLook = false;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var invert = invertVerticalLook ? -1 : 1;
            transform.eulerAngles -= Speed * new Vector3(invert * Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);

            //transform.Rotate(transform.up ,-Input.GetAxis("Mouse X") * Speed  ); //1
        }
    }
}