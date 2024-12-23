using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonNumber : MonoBehaviour
{
    public TextMeshProUGUI text1;// Text1 ������Ʈ�� ����
    private int currentNumber = 0;// �ʱⰪ ����

    public void OnButtonClick()// ��ư Ŭ�� �� ����
    {
        StartCoroutine(IncrementNumbers()); // ȣ���Ͽ� for������ ���� ���� �ڷ�ƾ ����
    }

    IEnumerator IncrementNumbers() // for���� ����� 0���� 10���� ���� �ݺ�
    {
        for (int i = 0; i <= 10; i++) // 0���� 10���� �ݺ�
        {
            text1.text = i.ToString(); // ���ڸ� �ؽ�Ʈ�� ǥ��
            Debug.Log(i); // �ֿܼ� ���� ���
            yield return new WaitForSeconds(0.5f); // 0.5�� ���
        }
        
    }

}
