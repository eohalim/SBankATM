using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomSceneManager : MonoBehaviour
{
    private string MainScene = "MainScene";
    private string CreditsScene = "CreditsScene";
    private string DebitsScene = "DebitsScene";
    private string LoanScene = "LoanScene";
    private string TransferScene = "TransferScene";

    public void LoadMainScene()
    {
        SceneManager.LoadScene(MainScene);
    }

    public void LoadCreditsScene()
    {
        SceneManager.LoadScene(CreditsScene);
    }

    public void LoadDebitsScene()
    {
        SceneManager.LoadScene(DebitsScene);
    }

    public void LoadTransferScene()
    {
        SceneManager.LoadScene(TransferScene);
    }

    public void LoadLoanScene()
    {
        SceneManager.LoadScene(LoanScene);
    }

}
