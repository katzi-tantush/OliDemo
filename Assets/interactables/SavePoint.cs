using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoint : MonoBehaviour
{
    SavePointService savePointState;

    private void Start()
    {
        savePointState = GameObject.FindObjectOfType<SavePointService>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            savePointState.VisitSavePoint(gameObject);
        }
    }
}
