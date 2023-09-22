using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    public float wallet;
    public Text WalletText;
    public Text AccountText;


    public void UpdateWalletText()
    {
        WalletText.text = "현금 잔액: " + wallet.ToString();
    }

    public float GetTransferAmount()
    {
        float accountBalance = float.Parse(AccountText.text);

        float walletBalance = float.Parse(WalletText.text);

        return walletBalance - accountBalance;
    }

    public void Transfer(float amount)
    {
        wallet -= amount;
    }
    //왜 넣는지 물어봐 오류떠서 챗치피티가 넣으랬음 
    public float GetTransferAmount(float accountBalance, float walletBalance)
    {
        return walletBalance - accountBalance;
    }

}
