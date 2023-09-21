using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginScene : MonoBehaviour
{
    public void Show()
    {
        SceneController.LoadScene("LoginScene");
    }

    public void GotoLoginScene()
    {
        SceneController.LoadScene("LoginScene");
    }
}