using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CreditsScene : MonoBehaviour
{
    public TMP_InputField NameInputfield;

    public void Show()
    {
        SceneController.LoadScene("CreditsScene");
    }

    public void GotoLoginScene()
    {
        SceneController.LoadScene("CreditsScene");
    }
}