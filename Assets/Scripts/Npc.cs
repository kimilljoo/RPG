using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Npc : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;

    private bool isPanel = false;


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
        if (Input.GetKeyDown(KeyCode.E) && panel.activeSelf == false)
        {
            panel.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Escape) && panel.activeSelf == true)
        {
            panel.SetActive(false);
        }
    }

    protected abstract void drawText();


}
