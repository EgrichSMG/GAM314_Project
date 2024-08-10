using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 2f;
    float cameraVerticalRotate = 0f;

    bool lockCursor = true;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse Input
        float inputX = Input.GetAxis("Mouse X")*mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y")*mouseSensitivity;

        cameraVerticalRotate -= inputY;
        cameraVerticalRotate = Mathf.Clamp(cameraVerticalRotate, -90, 90);
        transform.localEulerAngles = Vector3.right*cameraVerticalRotate;

        player.Rotate(Vector3.up * inputX);
    }
}
