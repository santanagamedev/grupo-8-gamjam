using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneController : MonoBehaviour
{
    public int health = 100; // Puntos de vida del jugador

    // Método para recibir daño
    public void TakeDamage(int damage)
    {
        health -= damage; // Resta el daño de la salud del jugador
        if (health <= 0)
        {
            Die(); // Llama al método de muerte si la salud es 0 o menos
        }
    }

    private void Die()
    {
        // Lógica para la muerte del jugador
        Debug.Log("El jugador ha muerto");
        // Puedes agregar lógica adicional aquí
    }
}
