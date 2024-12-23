using UnityEngine;
using UnityEngine.UI;


public class ButtonUIScript : MonoBehaviour
{
    public Button FirstButton;  // 첫번째 버튼
    public Button SecondButton; // 두번째 버튼
    public Button ThirdButton;  // 세번째 버튼
    public Text TextScript;     // public으로 유니티 접근 가능, Text를 쓰겠다 변수명은 TextScript

    void Start()
    {

        TextScript = GetComponent<Text>();  // 게임 오브젝트에 연결된 Text 컴포넌트를 찾아 반환한다. 이 컴포넌트를 찾아서 TextScript 변수에 저장한다.

        TextScript.text = "버튼을 눌러주세요."; // TextScript.text: Text 컴포넌트가 화면에 표시하는 문자열을 설정하는 속성. "버튼을 눌러주세요"라는 텍스트를 화면에 출력한다

        FirstButton.onClick.AddListener(FirstText); // AddListener 기능을 사용하여 버튼 클릭 후 불러올 함수 지정.
        SecondButton.onClick.AddListener(SecondText);
        ThirdButton.onClick.AddListener(ThirdText);

    }

    // 위에서 버튼 클릭 후 불러올 텍스트 함수들 지정
    void FirstText()    
    {
        TextScript.text = "First 버튼 눌렸습니다";
    }
    void SecondText()
    {
        TextScript.text = "Second 버튼 눌렸습니다";
    }
    void ThirdText()
    {
        TextScript.text = "Third 버튼 눌렸습니다";
    }

}
