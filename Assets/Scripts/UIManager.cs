using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text duckKillCountText;
    public GameObject inventory;
    private int inventoryOnOff = 0;

    private void Start()
    {
        //duckKillCountText = GetComponent<TextMeshProUGUI>();

    }

    private void Update()
    {

        DrawQuest();
        showInventory();

    }

    private void DrawQuest()
    {
        duckKillCountText.text = "Äù½ºÆ®: ¿À¸® " + GameManager.curQuestkillCount.ToString() + "/ 10";

    }

    private void showInventory()
    {
        if (Input.GetKeyDown(KeyCode.E) && inventoryOnOff % 2 == 0)
        {
            inventory.SetActive(true);
            Time.timeScale = 0;
            ++inventoryOnOff;
        }

        else if (Input.GetKeyDown(KeyCode.E) && inventoryOnOff % 2 != 0)
        {
            inventory.SetActive(false);
            Time.timeScale = 1;
            ++inventoryOnOff;
        }
    }


}
