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
        //  FirstButton�� Ŭ�� �� ���¸� ����.
        FirstRadioButton.onValueChanged.AddListener((isOn) => OnToggleClick(FirstRadioButton, isOn));
        //  isOn: onValueChanged�� �����ϴ� ����(true �Ǵ� false)
        //  OnToggleClick �Լ��� �ΰ��� �μ�(FirstRadioButton, isOn)�� ����
        //  ���ٽ��� ���� �̺�Ʈ�� �߻��� FirstRadioButton�� ���¸� OnToggleClick �Լ��� ����
        SecondRadioButton.onValueChanged.AddListener((isOn) => OnToggleClick(SecondRadioButton, isOn));
        ThirdRadioButton.onValueChanged.AddListener((isOn) => OnToggleClick(ThirdRadioButton, isOn));

        //FirstRadioButton.interactable = false;
        //SecondRadioButton.enabled = true;
        //ThirdRadioButton.enabled = true;
    }

    void OnToggleClick(Toggle clickedToggle, bool isOn) //  �� ���ٽ��� �Լ������� ���� �Լ� ����.
    //  Toggle clickedToggle: Ŭ�� �� ��� ��ü�� ��Ÿ����, �� �Լ��� ȣ��� �� Ŭ���� ����� ���޹޾� � ����� Ŭ�� �ƴ��� Ȯ��
    //  bool isOn: ����� ���� ���¸� ��Ÿ���� ture�� Ȱ��ȭ false�� ��Ȱ��ȭ
    {
        if (isOn)   
            //  Ŭ���� ����� ���� (true�� Ȱ��ȭ, false�� ��Ȱ��ȭ)
            //  Ŭ���� ����� Ȱ��ȭ ���¸� ������ ����� ��Ȱ��ȭ
        {
            if (clickedToggle != FirstRadioButton)  //  Ŭ���� ����� FirstRadioButton�� �ƴ϶��
            {
                FirstRadioButton.interactable = false;  //  ��Ȱ��ȭ �ض�
            }
            if (clickedToggle != SecondRadioButton) // Ŭ���� ����� SecondRadioButton�� �ƴ϶��
            {
                SecondRadioButton.interactable = false; //  ��Ȱ��ȭ �ض�
            }
            if (clickedToggle != ThirdRadioButton)  // Ŭ���� ����� ThirdRadioButton�� �ƴ϶��
            {
                ThirdRadioButton.interactable = false;  //  ��Ȱ��ȭ �ض�
            }

        }
        else 
            // ������ ����� isOn == false �� �� ���� �Ǹ�
            // Ŭ���� ����� ��Ȱ��ȭ�� ���ư��� ��� ����� �ٽ� Ȱ��ȭ 
        {
            FirstRadioButton.interactable = true;   //  Ȱ��ȭ
            SecondRadioButton.interactable = true;  //  Ȱ��ȭ
            ThirdRadioButton.interactable = true;   //  Ȱ��ȭ

        }

        // void Start()
        //{
        //    // �� ��ư�� �̺�Ʈ �߰�
        //    FirstButton.onClick.AddListener(() => OnButtonClicked(FirstButton));    // FirstButton�� �̺�Ʈ
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
