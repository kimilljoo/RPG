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
            text = "안녕하세요 소에요\n오리 훈제가 먹고싶어요\n오리 10마리를 잡아주세요";
        }

    }


}
