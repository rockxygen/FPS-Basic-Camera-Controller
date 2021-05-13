using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float rotationX;
    public float mouseSensitivty = 45f;

    public Transform player;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        float mY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivty;
        float mX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivty;

        rotationX -= mY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        transform.localEulerAngles = new Vector3(rotationX, 0f, 0f);

        player.Rotate(Vector3.up * mX);
    }
}
