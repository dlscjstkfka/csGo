using UnityEngine;
using UnityEngine.UI;

public class ToggleAdmin : MonoBehaviour
{
    public Toggle FirstRadioButton;
    public Toggle SecondRadioButton;
    public Toggle ThirdRadioButton;


    // Start is called before the first frame update
    void Start()
    {
        //  FirstButton을 클릭 시 상태를 변경.
        FirstRadioButton.onValueChanged.AddListener((isOn) => OnToggleClick(FirstRadioButton, isOn));
        //  isOn: onValueChanged가 전달하는 상태(true 또는 false)
        //  OnToggleClick 함수에 두개의 인수(FirstRadioButton, isOn)를 전달
        //  람다식을 통해 이벤트가 발생한 FirstRadioButton의 상태를 OnToggleClick 함수에 전달
        SecondRadioButton.onValueChanged.AddListener((isOn) => OnToggleClick(SecondRadioButton, isOn));
        ThirdRadioButton.onValueChanged.AddListener((isOn) => OnToggleClick(ThirdRadioButton, isOn));

        //FirstRadioButton.interactable = false;
        //SecondRadioButton.enabled = true;
        //ThirdRadioButton.enabled = true;
    }

    void OnToggleClick(Toggle clickedToggle, bool isOn) //  위 람다식의 함수실행을 위한 함수 설정.
    //  Toggle clickedToggle: 클릭 된 토글 객체를 나타내며, 이 함수가 호출될 때 클릭된 토글을 전달받아 어떤 토글이 클릭 됐는지 확인
    //  bool isOn: 토글의 현재 상태를 나타내며 ture는 활성화 false는 비활성화
    {
        if (isOn)   
            //  클릭된 토글의 상태 (true는 활성화, false는 비활성화)
            //  클릭된 토글이 활성화 상태면 나머지 토글이 비활성화
        {
            if (clickedToggle != FirstRadioButton)  //  클릭한 토글이 FirstRadioButton이 아니라면
            {
                FirstRadioButton.interactable = false;  //  비활성화 해라
            }
            if (clickedToggle != SecondRadioButton) // 클릭한 토글이 SecondRadioButton이 아니라면
            {
                SecondRadioButton.interactable = false; //  비활성화 해라
            }
            if (clickedToggle != ThirdRadioButton)  // 클릭한 토글이 ThirdRadioButton이 아니라면
            {
                ThirdRadioButton.interactable = false;  //  비활성화 해라
            }

        }
        else 
            // 위에서 언급한 isOn == false 일 때 실행 되며
            // 클릭한 토글이 비활성화로 돌아가면 모든 토글이 다시 활성화 
        {
            FirstRadioButton.interactable = true;   //  활성화
            SecondRadioButton.interactable = true;  //  활성화
            ThirdRadioButton.interactable = true;   //  활성화

        }

        // void Start()
        //{
        //    // 각 버튼의 이벤트 추가
        //    FirstButton.onClick.AddListener(() => OnButtonClicked(FirstButton));    // FirstButton의 이벤트
        //    SecondButton.onClick.AddListener(() => OnButtonClicked(SecondButton));   // 
        //    ThirdButton.onClick.AddListener(() => OnButtonClicked(ThirdButton));    // 

        //    ResetAllButtons();
        //}

        //void OnButtonClicked(Button clickButton)
        //{
        //    if (activeButton == clickButton)
        //    {
        //        ResetAllButtons();
        //    }
        //    else
        //    {
        //        SetAllButtons(false);
        //        clickButton.interactable = true;
        //        activeButton = clickButton;
        //    }
        //}
        // Update is called once per frame

    }
}
