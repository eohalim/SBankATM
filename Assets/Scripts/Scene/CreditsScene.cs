using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScene : MonoBehaviour
{
    public void Show()
    {
        SceneController.LoadScene("CreditsScene");
    }

    public void GotoLoginScene()
    {
        SceneController.LoadScene("CreditsScene");
    }
}