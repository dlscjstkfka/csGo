using UnityEngine;
using UnityEngine.UI;

public class ButtonAdmin : MonoBehaviour
{
    public Button FirstButton;  // 첫번째 버튼
    public Button SecondButton; // 두번째 버튼
    public Button ThirdButton;  // 세번째 버튼

    private Button activeButton = null;

    void Start()
    {
        // 각 버튼의 이벤트 추가
        FirstButton.onClick.AddListener(() => OnButtonClicked(FirstButton));    
        SecondButton.onClick.AddListener(() => OnButtonClicked(SecondButton));   
        ThirdButton.onClick.AddListener(() => OnButtonClicked(ThirdButton));    

        ResetAllButtons();
    }

    void OnButtonClicked(Button clickButton)
    {
        if (activeButton == clickButton)
        {
            ResetAllButtons();
        }
        else
        {
            SetAllButtons(false);
            clickButton.interactable = true;
            activeButton = clickButton;
        }
    }

    //void OnButtonClicked(Button ClickButton)
    //{
    //    if (ClickButton == FirstButton)   // 클릭한 버튼이 FirstButton 이라면..
    //    {
    //        ButtonSetting(SecondButton, false);   // SecondButton 비활성화
    //        ButtonSetting(ThirdButton, false);    // ThirdButton 비활성화

    //    }
    //    else if (ClickButton == SecondButton)   // 같은 맥락
    //    {
    //        ButtonSetting(FirstButton, false);
    //        ButtonSetting(ThirdButton, false);

    //    }
    //    else if (ClickButton == ThirdButton)    // 같은 맥락
    //    {
    //        ButtonSetting(FirstButton, false);
    //        ButtonSetting(SecondButton, false);

    //    }

    //    ButtonSetting(ClickButton, true);

    //}


    //void ButtonSetting(Button button, bool state)
    //{
    //    button.interactable = state;

    //}

    //void OnButtonClicked(Button ClickedButton)
    //{
    //    if (isAnyButtonDisabled)
    //    {
    //        SetAllButtons(true);
    //        isAnyButtonDisabled = false;
    //    }
    //    else
    //    {
    //        SetAllButtons(false);
    //        ClickedButton.interactable = true;
    //        isAnyButtonDisabled = true;
    //    }
    //}

    void SetAllButtons(bool state)
    {
        FirstButton.interactable = state;
        SecondButton.interactable = state;
        ThirdButton.interactable = state;

        //SetSelectedState(FirstButton, false);
        //SetSelectedState(SecondButton, false);
        //SetSelectedState(ThirdButton, false);
    }

    void ResetAllButtons()
    {
        // 모든 버튼을 초기 상태로 복원
        SetAllButtons(true);
        activeButton = null; // 활성 버튼 초기화
    }
}
