using UnityEngine;
using UnityEngine.UI;


public class ButtonUIScript : MonoBehaviour
{
    public Button FirstButton;  // ù��° ��ư
    public Button SecondButton; // �ι�° ��ư
    public Button ThirdButton;  // ����° ��ư
    public Text TextScript;     // public���� ����Ƽ ���� ����, Text�� ���ڴ� �������� TextScript

    void Start()
    {

        TextScript = GetComponent<Text>();  // ���� ������Ʈ�� ����� Text ������Ʈ�� ã�� ��ȯ�Ѵ�. �� ������Ʈ�� ã�Ƽ� TextScript ������ �����Ѵ�.

        TextScript.text = "��ư�� �����ּ���."; // TextScript.text: Text ������Ʈ�� ȭ�鿡 ǥ���ϴ� ���ڿ��� �����ϴ� �Ӽ�. "��ư�� �����ּ���"��� �ؽ�Ʈ�� ȭ�鿡 ����Ѵ�

        FirstButton.onClick.AddListener(FirstText); // AddListener ����� ����Ͽ� ��ư Ŭ�� �� �ҷ��� �Լ� ����.
        SecondButton.onClick.AddListener(SecondText);
        ThirdButton.onClick.AddListener(ThirdText);

    }

    // ������ ��ư Ŭ�� �� �ҷ��� �ؽ�Ʈ �Լ��� ����
    void FirstText()    
    {
        TextScript.text = "First ��ư ���Ƚ��ϴ�";
    }
    void SecondText()
    {
        TextScript.text = "Second ��ư ���Ƚ��ϴ�";
    }
    void ThirdText()
    {
        TextScript.text = "Third ��ư ���Ƚ��ϴ�";
    }

}
