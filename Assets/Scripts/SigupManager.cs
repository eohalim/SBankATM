using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SignupManager : MonoBehaviour
{
    public TMP_InputField NameInputField;
    public TMP_InputField PwInputField;
    public ButtonController SignupBtn;

    private UserDB[] newBie = new UserDB[600];

    [System.Serializable]
    public class UserDB
    {
        public string Name;
        public string Pw;
    }

    public void SignupBtnButtonClick()
    {
        TMP_InputField NameInputFIeld = FindObjectOfType<TMP_InputField>();
        TMP_InputField PwInputFIeld = FindObjectOfType<TMP_InputField>();

        for (int i = 0; i < newBie.Length; i++)
        {
            if (newBie[i] == null)
            {
                newBie[i] = new UserDB();
                newBie[i].Name = NameInputField.text;
                newBie[i].Pw = PwInputField.text;
             
                break;
            }   
        }
    }
}
