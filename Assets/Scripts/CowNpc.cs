using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CowNpc : Npc
{
    [SerializeField]
    private TMP_Text cowText;
    protected override void drawText()
    {
        cowText.text = NpcText.text;
    }

    private void Update()
    {
        drawText();
        if (isPanel == true)
        {
            Interaction();
        }
    }
}
