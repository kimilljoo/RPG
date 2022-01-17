using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcQuest : MonoBehaviour
{ 

    static public bool isQuest = false;

    private void Start()
    {
        isQuest = false;
    }

    private void Update()
    { 
        if(GameManager.duckKillCount == 10)
        {
            isQuest = true;
        }

    }


}
