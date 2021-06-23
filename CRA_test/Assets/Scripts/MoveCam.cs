using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    Vector2 rotation = Vector2.zero;
    public float speed = 1;
    public bool visbleMouse = false;
    bool rotMouse = true;
    public ControlTouchField touch;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        rotation.y += touch.touchdistance.x;
        rotation.x += -touch.touchdistance.y;
        transform.eulerAngles = (Vector2)rotation * speed;

        if (rotMouse == true)
        {
            _Mouse();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(visbleMouse == true)
            {                
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                visbleMouse = false;
                rotMouse = true;
            }
            else
            {                
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                visbleMouse = true;
                rotMouse = false;
            }

        }
    }

    private void _Mouse()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");
        transform.eulerAngles = (Vector2)rotation * speed;
    }

    //EDIT: Even cleaner
}
