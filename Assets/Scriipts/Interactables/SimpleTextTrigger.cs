using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SimpleTextTrigger : MonoBehaviour
{
    public string text;
    public GameObject textObj;
    TMP_Text displayText;
    bool triggeredOnce = false;

    void Start()
    {
        displayText = textObj.GetComponent<TMP_Text>();
    }

    public void SetText() 
    {
        displayText.text = text;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!triggeredOnce)
            {
                SetText();
                displayText.enabled = true;
            }
            triggeredOnce = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            displayText.enabled = false;
        }
    }
}
