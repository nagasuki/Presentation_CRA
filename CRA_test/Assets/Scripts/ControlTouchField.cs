using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControlTouchField : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public Vector2 touchdistance;
    public Vector2 pointbefore;
    protected int pointid;
    public bool pressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
        pointid = eventData.pointerId;
        pointbefore = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pressed)
        {
            if (pointid >= 0 && pointid < Input.touches.Length)
            {
                touchdistance = Input.touches[pointid].position - pointbefore;
                pointbefore = Input.touches[pointid].position;
            }
            else
            {
                touchdistance = new Vector2(Input.mousePosition.x, Input.mousePosition.y) - pointbefore;
                pointbefore = Input.mousePosition;
            }
        }
        else
        {
            touchdistance = new Vector2();
        }
    }
}
