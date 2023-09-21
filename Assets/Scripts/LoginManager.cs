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

    private readonly string valiName = "name";//valiName으로 안쓰고 name 으로 써서 오류뜸 이하 동문  
    private readonly string valiPassword = "1234";

    public void LoginBtnClick()
    {
        if(NameInputField.text == valiName && PwInputField.text == valiPassword)
        {
            LoginScene.SetActive(true);

            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("가입을 진행하세요!");
        }
    }

}
