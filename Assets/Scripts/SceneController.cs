using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneController
{
    public static void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public static void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}











/* 'SceneController' 클래스에 'LoadScene' 메서드가 정의되어 있지 않다는 오류 뜸 
 public static class SceneController
{
    public static void ChangeSceneToMain(string MainScene)
    {
        SceneManager.LoadScene(MainScene);
    }
    public static void ChangeSceneToLogin(string LoginScene)
    {
        SceneManager.LoadScene(LoginScene);
    }
    public static void ChangeSceneToCredits(string CreditsScene)
    {
        SceneManager.LoadScene(CreditsScene);
    }
    public static void ChangeSceneToDebits(string DebitsScene)
    {
        SceneManager.LoadScene(DebitsScene);
    }
    public static void ChangeSceneToTransfer(string TransferScene)
    {
        SceneManager.LoadScene(TransferScene);
    }
    public static void ChangeSceneToLoan(string LoanScene)
    {
        SceneManager.LoadScene(LoanScene);
    }
}
*/
/*public class CustemSceneManager : MonoBehaviour
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
*/