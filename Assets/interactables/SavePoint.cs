using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoint : MonoBehaviour
{
    GameObject saveDisk;
    SavePointState savePointState;

    private void Start()
    {
        savePointState = GameObject.FindObjectOfType<SavePointState>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            savePointState.VisitSavePoint(gameObject);
        }
    }
}
