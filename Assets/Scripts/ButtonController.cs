using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject SignupPopup;
    public Wallet wallet;
    public Account bankAccount;

    public void CreditsBtnButtonClick()
    {
        SceneController.ChangeScene("CreditsScene");
    }

    public void DebitsBtnButtonClick()
    {
        SceneController.ChangeScene("DebitsScene");
    }

    public void LoanBtnButtonClick()
    {
        SceneController.ChangeScene("LoanScene");
    }

    public void TransferBtnButtonClick()
    {
        SceneController.ChangeScene("TransferScene");
    }

    public void LoginBtnButtonClick()
    {
        SceneController.ChangeScene("MainScene");
    }

    public void SignupBtnButtonClick()
    {
        SignupPopup.SetActive(true);
    }

    public void CompletedBtnButtonClick()
    {
        SceneController.ChangeScene("LoginScene");
    }

    public void BsckBtnButtonClick()
    {
        SceneController.ChangeScene("MainScene");
    }

    public void CreditBtnClick()
    {
        float transferAmount = wallet.GetTransferAmount();

        if (transferAmount > 0)
        {
            wallet.Transfer(transferAmount);
            bankAccount.Deposit(transferAmount); 
        }
    }

    public void MBtnButtonClick()
    {
        float transferAmount = 10000;

        if (wallet.wallet >= transferAmount)
        {
            wallet.wallet -= transferAmount;
            bankAccount.account += transferAmount;
        }
    }

    public void TMBtnButtonClick()
    {
        float transferAmount = 30000;

        if (wallet.wallet >= transferAmount)
        {
            wallet.wallet -= transferAmount;
            bankAccount.account += transferAmount;
        }
    }

    public void FTBtnButtonClick()
    {
        float transferAmount = 5000;

        if (wallet.wallet >= transferAmount)
        {
            wallet.wallet -= transferAmount;
            bankAccount.account += transferAmount;
        }
    }

    public void okBtnButtonClick()
    {
        SceneController.ChangeScene("MainScene");
    }

    public void CreditBtnButtonClick()
    {

    }
}
