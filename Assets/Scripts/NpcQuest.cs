using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcQuest : MonoBehaviour
{ 

    private void Start()
    {
        GameManager.isQuest = false;
    }

    private void Update()
    { 

        
    }

    public void SetQuest(ref int maxQuestKill, int changeMaxQuestKill)
    {
        maxQuestKill = changeMaxQuestKill;
    }

    public void CheckCompleteQuest()
    {
        if(GameManager.curQuestkillCount == GameManager.maxQuestKillCount)
        {
            GameManager.isCompleteQuest = true;
            Debug.Log(GameManager.isCompleteQuest);
        }
    }


    public void AcceptQuest()
    {
        GameManager.isQuest = true;
    }

    public void CancleQuest()
    {
        GameManager.isQuest = false;

    }

}
