using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform Player;
    public Vector3 offset;
    public float smoothspeed = 0.125f;
    float xRotation = 0f;
    float mousesensitivity = 100f;
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mousesensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousesensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f) ;
        Player.Rotate(Vector3.up * mouseX);
        Vector3 desiredposation = Player.position + offset;
        Vector3 smoothposation = Vector3.Lerp(transform.position, desiredposation,smoothspeed);
        transform.position = smoothposation;
  
    }


}
    