using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoginManager : MonoBehaviour
{
    public GameObject LoginScene;

    public TMP_InputField NameInputField;
    public TMP_InputField PwInputField;
    public ButtonController LoginBtn;
    public ButtonController SignupBtn;

    private readonly string name = "name";
    private string password = "1234";

    public CustomSceneManager customSceneManager;

    public void LoginBtnClick()
    {
        if(NameInputField.text == name && PwInputField.text == password)
        {
            Debug.Log("로그인 성공");
            LoginScene.SetActive(false);

            customSceneManager.LoadMainScene();
        }
        else
        {
            Debug.Log("로그인 실패");
        }
    }

}
