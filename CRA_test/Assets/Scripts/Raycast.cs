using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Raycast : MonoBehaviour
{
    public Text _text, _text2;
    public GameObject _video, _button, _look;
    // Start is called before the first frame update
    void Start()
    {
        //CloseButton();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CloseButton();
        }

        Ray _ray = Camera.main.ScreenPointToRay(_look.transform.position - this.transform.position);
        Debug.DrawRay(_ray.origin, _ray.direction * 100, Color.red);
        RaycastHit _hit;
        
        if (!Physics.Raycast(_ray, out _hit, 100))
        {
            _text.enabled = false;
            _text2.enabled = false;
            return;
        }

        if (_hit.collider.name == "Cube" )
        {
            _text.enabled = true;
            if (Input.GetMouseButtonDown(0) || ControlTouchField.FindObjectOfType<ControlTouchField>().pressed == true)
            {
                FindObjectOfType<ChangeScene>()._ChageScene();
            }
        }

        else if (_hit.collider.name == "Cube (1)")
        {
            _text2.enabled = true;

            if (Input.GetMouseButtonDown(0) || ControlTouchField.FindObjectOfType<ControlTouchField>().pressed == true)
            {
                _video.SetActive(true);
                _button.SetActive(true);
            }
        }
    }

    public void CloseButton()
    {
        _video.SetActive(false);
        _button.SetActive(false);
    }
}
