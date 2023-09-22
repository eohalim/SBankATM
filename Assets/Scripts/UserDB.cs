using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class UserDB : MonoBehaviour
{
    public string Name;
    public string Pw;
}

[System.Serializable]
public class UserAccount
{
    public float Account;
}

[System.Serializable]
public class UserWallet
{
    public float Wallet;
}

public class UserDataManager : MonoBehaviour
{
    private List<UserDB> userList = new List<UserDB>();

    public void AddUserDB(string userName, string userPw)
    {
        UserDB user = new UserDB();
        user.Name = userName;
        user.Pw = userPw;
        userList.Add(user);
    }

    public bool VerifyUserDB(string userName, string userPw)
    {
        foreach (var user in userList)
        {
            if (user.Name == userName && user.Pw == userPw)
            {
                return true;
            }
        }
        return false;
    }

    public List<string> GetUserNames()
    {
        List<string> userNames = new List<string>();

        foreach (var user in userList)
        {
            userNames.Add(user.Name);
        }

        return userNames;
    }
}

public class Account : MonoBehaviour
{
    public Text balanceText; 
    public float account;

    void Start()
    {
        UpdateBalanceText(); 
    }

    public void UpdateBalanceText()
    {
        balanceText.text = "계좌 잔액: " + account.ToString(); 
    }

    public void Deposit(float amount)
    {
        account += amount;
        UpdateBalanceText();
    }
}


