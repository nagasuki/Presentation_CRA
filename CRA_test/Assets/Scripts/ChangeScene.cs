using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static int index = 0;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && index < 1)
        {
            index += 1;
            SceneManager.LoadScene(index);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && index != 0)
        {
            index -= 1;
            SceneManager.LoadScene(index);
        }
    }

    public void _ChageScene()
    {
        index += 1;
        SceneManager.LoadScene(1);
    }

    public void _ChageSceneDefult()
    {
        SceneManager.LoadScene(0);
    }

}
