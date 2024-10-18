using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneController : MonoBehaviour
{
    public int health = 100; // Puntos de vida del jugador

    // M�todo para recibir da�o
    public void TakeDamage(int damage)
    {
        health -= damage; // Resta el da�o de la salud del jugador
        if (health <= 0)
        {
            Die(); // Llama al m�todo de muerte si la salud es 0 o menos
        }
    }

    private void Die()
    {
        // L�gica para la muerte del jugador
        Debug.Log("El jugador ha muerto");
        // Puedes agregar l�gica adicional aqu�
    }
}
