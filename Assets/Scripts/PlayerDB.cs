using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserDB : MonoBehaviour
{
    public string Name;
    public string Pw;
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
}
