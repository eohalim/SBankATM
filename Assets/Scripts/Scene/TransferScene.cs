using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransferScene : MonoBehaviour
{
    public void Show()
    {
        SceneController.LoadScene("TransferScene");
    }

    public void GotoLoginScene()
    {
        SceneController.LoadScene("TransferScene");
    }
}