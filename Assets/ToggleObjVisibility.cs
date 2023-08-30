using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjVisibility : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;

    private bool isObj1Visible = true;

    void Start()
    {
        obj1.SetActive(isObj1Visible);
        obj2.SetActive(!isObj1Visible);
    }

    // Update is called once per frame
    void Update()
    {
        HandleVisisbilityToggle();
    }

    private void HandleVisisbilityToggle()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isObj1Visible = !isObj1Visible;
            obj1.SetActive(isObj1Visible);
            obj2.SetActive(!isObj1Visible);
        }

    }
}
