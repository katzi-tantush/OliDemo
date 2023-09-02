using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DeathService : MonoBehaviour
    // a bit morbid...
{
    GameObject player;
    SavePointService savePointService;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        savePointService = GameObject.FindObjectOfType<SavePointService>();
    }

    public void HandlePlayerDeath()
    {
        GameObject lastSavePoint = savePointService.GetLastVisited();
        player.transform.position = lastSavePoint.transform.position;
    }
}
