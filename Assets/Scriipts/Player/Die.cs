using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    DeathService deathService;

    private void Start()
    {
        deathService = GameObject.FindObjectOfType<DeathService>();
    }

    void Update()
    {
        bool playerHasFallen = gameObject.transform.position.y < -3;

        if (playerHasFallen)
        {
            deathService.HandlePlayerDeath();
        }
    }
}
