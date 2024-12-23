using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonNumber : MonoBehaviour
{
    public TextMeshProUGUI text1;// Text1 컴포넌트에 연결
    private int currentNumber = 0;// 초기값 설정

    public void OnButtonClick()// 버튼 클릭 시 실행
    {
        StartCoroutine(IncrementNumbers()); // 호출하여 for문으로 숫자 증가 코루틴 실행
    }

    IEnumerator IncrementNumbers() // for문을 사용해 0부터 10까지 숫자 반복
    {
        for (int i = 0; i <= 10; i++) // 0부터 10까지 반복
        {
            text1.text = i.ToString(); // 숫자를 텍스트로 표시
            Debug.Log(i); // 콘솔에 숫자 출력
            yield return new WaitForSeconds(0.5f); // 0.5초 대기
        }
        
    }

}
