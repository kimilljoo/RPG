using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcText : MonoBehaviour
{
    static public string text;



    private void Start()
    {
        ChangeText();

    }

    private void ChangeText()
    {
        if(GameManager.isQuest == false)
        {
            text = "�ȳ��ϼ��� �ҿ���\n���� ������ �԰�;��\n���� 10������ ����ּ���";
        }

    }


}
