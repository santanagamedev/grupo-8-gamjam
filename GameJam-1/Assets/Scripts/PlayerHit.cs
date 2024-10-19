using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    private GameManager gameManager;

     void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); // Encuentra el GameManager
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Zombie"))
            Destroy(other.gameObject);
            gameManager.EnemyDestroyed(1); 

    }
}
