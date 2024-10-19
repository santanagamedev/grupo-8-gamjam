using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int health = 100; // Puntos de vida del zombi
    public int attackDamage = 8; // Da�o que hace al jugador
    public int damageTaken = 35; // Da�o que recibe el zombi
    public float attackRange = 2.0f; // Rango de ataque
    public float moveSpeed = 2.0f; // Velocidad de movimiento hacia el jugador
    public float attackCooldown = 1.5f; // Tiempo entre ataques

    private Animator animator; // Para las animaciones
    private PlayerOneController playerOneController; // Referencia al PlayerOneController
    private Transform player; // Referencia al transform del jugador
    private float lastAttackTime = 0f; // Tiempo desde el �ltimo ataque

    void Start()
    {
        animator = GetComponent<Animator>(); 
        player = GameObject.Find("Player").transform; 
        playerOneController = player.GetComponent<PlayerOneController>();
    }

    void Update()
    {
        
        if (Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            Attack();
        }
        else
        {
            MoveTowardsPlayer();
        }
    }

    
    private void MoveTowardsPlayer()
    {
        Debug.Log("Zombie is moving towards player.");
        transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
    }

    public void Attack()
    {
        if (playerOneController != null)
        {
            Debug.Log("Zombie is attacking.");
            playerOneController.TakeDamage(attackDamage); 
            animator.SetTrigger("attack"); 
            lastAttackTime = Time.time; 
        }
    }

    
    public void TakeDamage()
    {
        health -= damageTaken;
        Debug.Log("Zombie took damage.");
        animator.SetTrigger("damage"); 

        if (health <= 0)
        {
            Die(); 
        }
    }

    
    private void Die()
    {
        Debug.Log("Zombie has died.");
        animator.SetTrigger("death"); 
        Destroy(gameObject, 2f); 
    }
}
