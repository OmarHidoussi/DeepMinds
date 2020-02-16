using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float MouseSensitivity = 100f;

    public Transform PlayerBody;

    public bool LockCuror;
    private float xRotation;

    [HideInInspector]
    public Vector2 LoockAxis;

    void Start()
    {
        if(LockCuror)
            Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * mouseX);
    }
}
