using UnityEngine;
using UnityEngine.UI;

public class ToggleTextAdmin : MonoBehaviour
{
    public Toggle FirstRadioButton;
    public Toggle SecondRadioButton;
    public Toggle ThirdRadioButton;
    public Text TextScript;
    

    void Start()
    {
        TextScript = GetComponent<Text>();
        TextScript.text = "��ư�� �����ּ���.";

        FirstRadioButton.onValueChanged.AddListener((isOn) => OnToggleFirstText(FirstRadioButton, isOn));
        SecondRadioButton.onValueChanged.AddListener((isOn) => OnToggleSecondText(SecondRadioButton, isOn));
        ThirdRadioButton.onValueChanged.AddListener((isOn) => OnToggleThirdText(ThirdRadioButton, isOn));

    }

    void OnToggleFirstText(Toggle FirstTextedToggle, bool isOn)
    {
        if (isOn)
        {
            TextScript.text = "<color=#52CC84>First Radio</color> Ȱ��ȭ �ƽ��ϴ�\n" + TextScript.text;

        }
        else {
            TextScript.text = "<color=#52CC84>First Radio</color> ��Ȱ��ȭ �ƽ��ϴ�\n" + TextScript.text;
        }

    }

    void OnToggleSecondText(Toggle SecondTextedToggle, bool isOn) {
        if (isOn)
        {
            TextScript.text = "<color=#76F1F8>Second Radio</color> Ȱ��ȭ �ƽ��ϴ�\n" + TextScript.text;

        }
        else
        {
            TextScript.text = "<color=#76F1F8>Second Radio</color> ��Ȱ��ȭ �ƽ��ϴ�\n" + TextScript.text;
        }

    }

    void OnToggleThirdText(Toggle ThirdTextedToggle, bool isOn)
    {
        if (isOn)
        {
            TextScript.text = "<color=#F8B071>Third Radio</color> Ȱ��ȭ �ƽ��ϴ�\n" + TextScript.text;

        }
        else
        {
            TextScript.text = "<color=#F8B071>Third Radio</color> ��Ȱ��ȭ �ƽ��ϴ�\n" + TextScript.text;
        }

    }

    





}
