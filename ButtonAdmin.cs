using UnityEngine;
using UnityEngine.UI;

public class ButtonAdmin : MonoBehaviour
{
    public Button FirstButton;  // ù��° ��ư
    public Button SecondButton; // �ι�° ��ư
    public Button ThirdButton;  // ����° ��ư

    private Button activeButton = null;

    void Start()
    {
        // �� ��ư�� �̺�Ʈ �߰�
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
    //    if (ClickButton == FirstButton)   // Ŭ���� ��ư�� FirstButton �̶��..
    //    {
    //        ButtonSetting(SecondButton, false);   // SecondButton ��Ȱ��ȭ
    //        ButtonSetting(ThirdButton, false);    // ThirdButton ��Ȱ��ȭ

    //    }
    //    else if (ClickButton == SecondButton)   // ���� �ƶ�
    //    {
    //        ButtonSetting(FirstButton, false);
    //        ButtonSetting(ThirdButton, false);

    //    }
    //    else if (ClickButton == ThirdButton)    // ���� �ƶ�
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
        // ��� ��ư�� �ʱ� ���·� ����
        SetAllButtons(true);
        activeButton = null; // Ȱ�� ��ư �ʱ�ȭ
    }
}
