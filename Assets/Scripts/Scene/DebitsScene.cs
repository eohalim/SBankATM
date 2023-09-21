using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebitsScene : MonoBehaviour
{
    public void Show()
    {
        SceneController.LoadScene("DebitsScene");
    }

    public void GotoLoginScene()
    {
        SceneController.LoadScene("DebitsScene");
    }
}