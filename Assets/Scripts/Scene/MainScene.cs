using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    public void Show()
    {
        SceneController.LoadScene("MainScene");//changescene써야되는지 loadscene써여되는지 모르겠음 스크립트 다 만들고 고쳐 
    }

    public void GotoMainScene()
    {
        SceneController.LoadScene("MainScene");
    }
}
