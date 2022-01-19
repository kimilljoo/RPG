using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CowNpc : Npc
{
    [SerializeField]
    private TMP_Text cowText;
    protected override void DrawText()
    {
        cowText.text = NpcText.text;
    }

    private void Update()
    {
        DrawText();
        if (isPanel == true)
        {
            Interaction();
        }
    }
}
