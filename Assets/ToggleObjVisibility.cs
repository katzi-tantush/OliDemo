using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ToggleObjVisibility : MonoBehaviour
{
    private bool areAToggleablesVisisble = true;

    void Start()
    {
        SetAllToggleablesVisibility();
    }

    void Update()
    {
        HandleVisisbilityToggle();
    }

    private void HandleVisisbilityToggle()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            areAToggleablesVisisble = !areAToggleablesVisisble;

            SetAllToggleablesVisibility();
        }
    }

    private void SetSingleToggleablesArrVisibility(GameObject[] toggleables, bool visible)
    {
            foreach (GameObject gameObj in toggleables)
            {
                gameObj.SetActive(visible);
            }
    }

    private void SetAllToggleablesVisibility()
    {
        GameObject[] toggleablesA = GameObject.FindObjectsOfType<ToggleableVisibilityA>(true).Select(type => type.transform.gameObject).ToArray();
        GameObject[] toggleablesB = GameObject.FindObjectsOfType<ToggleableVisibilityB>(true).Select(type => type.transform.gameObject).ToArray();
   
        SetSingleToggleablesArrVisibility(toggleablesA, areAToggleablesVisisble);
        SetSingleToggleablesArrVisibility(toggleablesB, !areAToggleablesVisisble);
    }
}
