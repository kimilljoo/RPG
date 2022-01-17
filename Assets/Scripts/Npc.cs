using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Npc : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;
    [SerializeField]
    private GameObject questUi;

    protected bool isPanel = false;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isPanel = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPanel = false;
        }

    }

    private void Update()
    {
        if(isPanel == true)
        {
            Interaction();
        }
    }


    protected void Interaction()
    {
        if (Input.GetKeyDown(KeyCode.F) && panel.activeSelf == false)
        {
            panel.SetActive(true);
            CursorManager.isCursor = true;
            
        }
        if(Input.GetKeyDown(KeyCode.Escape) && panel.activeSelf == true)
        {
            panel.SetActive(false);
            CursorManager.isCursor = false;
        }
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
        CursorManager.isCursor = false;
    }

    public void SetQuest()
    {
        questUi.SetActive(true);
    }

    protected abstract void drawText();


}
