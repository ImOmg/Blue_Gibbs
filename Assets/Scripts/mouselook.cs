using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public float mouseSens = 100f;
    public Transform playerBody;
    float xRoation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRoation -= mouseY;
        xRoation = Mathf.Clamp(xRoation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRoation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
