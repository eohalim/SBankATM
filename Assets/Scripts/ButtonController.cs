using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
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

    /*회원가입팝업 아직 음슴 
    public void SignupButtonClick()
    {
        SceneController.ChangeUI_Popup("UI_Pop");
    }
    */
}


    /* 애니메이션 효과 버튼 크기 달라지는 것 넣을 예정 미정 사오정  
    public Animator animator;

    void Start()
    {
        // Animator 컴포넌트 가져오기 (Inspector에서 연결)
        if (animator == null)
            animator = GetComponent<Animator>();

        // 버튼에 이벤트 리스너 추가
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(PlayAnimation);
        }
    }

    void PlayAnimation()
    {
        // 애니메이션 재생
        animator.speed = 1; // 속도를 1로 설정하여 재생
    }

    void Update()
    {
        if (!Input.GetMouseButton(0)) // 만약 마우스 왼쪽 버튼을 누르지 않았다면
        {
            // 애니메이션 멈춤
            animator.speed = 0; // 속도를 0으로 설정하여 멈춤
        }
    }
*/
