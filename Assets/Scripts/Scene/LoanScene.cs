using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoanScene : MonoBehaviour
{
    public void Show()
    {
        SceneController.LoadScene("LoanScene");
    }

    public void GotoLoginScene()
    {
        SceneController.LoadScene("LoanScene");
    }
}