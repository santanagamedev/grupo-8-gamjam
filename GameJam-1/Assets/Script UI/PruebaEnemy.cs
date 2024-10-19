using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaEnemy : MonoBehaviour
{
    private GameManager gameManager;

   private float danio = 10f; // Cambia este valor a lo que quieras

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); // Encuentra el GameManager
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Llama a la función Attack en GameManager
            gameManager.EnemyDestroyed(1); // Simula la destrucción del enemigo
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            gameManager.RestarVida(danio); // Resta la cantidad de daño
            Debug.Log("Aplicando daño de: " + danio);
        }
    }
}
