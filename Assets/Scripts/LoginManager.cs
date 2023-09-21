using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginManager : MonoBehaviour
{
    public GameObject LoginScene;

    public TMP_InputField NameInputField;
    public TMP_InputField PwInputField;
    public ButtonController LoginBtn;
    public ButtonController SignupBtn;

    public UserDataManager userDataManager;

    public void LoginBtnClick()
    {
        string inputName = NameInputField.text;
        string inputPassword = PwInputField.text;

        if(userDataManager.VerifyUserDB(inputName, inputPassword))
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("가입을 진행하세요!");
        }
    }

}
