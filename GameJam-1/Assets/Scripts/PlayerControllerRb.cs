using UnityEngine;

public class PlayerControllerRb : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    public GameObject playerMesh;
    private Animator playerAnimator;

    // Variables para los límites del terreno cilíndrico
    public Vector3 center = new Vector3(0, 0, 0); // Centro del cilindro
    public float radius = 23.5f; // Radio del cilindro

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerAnimator = GetComponentInChildren<Animator>();    
    }

    void Update()
    {
        // Control del movimiento horizontal
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Crear un vector de movimiento en base a los inputs
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized * speed; // Movimiento normalizado

        // Nueva posición del jugador
        Vector3 newPosition = rb.position + movement * Time.deltaTime;

        // Restricción de movimiento dentro del radio del cilindro
        Vector3 horizontalPosition = new Vector3(newPosition.x, 0, newPosition.z);

        // Si la distancia desde el centro del cilindro al nuevo movimiento es mayor que el radio, ajustamos la nueva posición
        if (Vector3.Distance(horizontalPosition, center) > radius)
        {
            Vector3 direction = (horizontalPosition - center).normalized;
            newPosition = center + direction * radius; // Ajustar la posición al límite
        }

        // Aplicar el movimiento con MovePosition
        rb.MovePosition(newPosition);

        // Rota al player según la dirección en que se mueva
        if (moveVertical > 0)
        {
            playerMesh.transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        else if (moveVertical < 0)
        {
            playerMesh.transform.localEulerAngles = new Vector3(0, 180, 0);              
        }
        else if (moveHorizontal > 0)
        {
            playerMesh.transform.localEulerAngles = new Vector3(0, 90, 0);               
        }
        else if (moveHorizontal < 0)
        {
            playerMesh.transform.localEulerAngles = new Vector3(0, 270, 0);               
        }

        // Activar o desactivar la animación "Running" según el movimiento
        if (moveHorizontal != 0 || moveVertical != 0)
        {
            playerAnimator.SetBool("Running", true);  // Activa la animación de correr
        }
        else
        {
            playerAnimator.SetBool("Running", false);  // Desactiva la animación de correr
        }

        // Animación y acción de golpear
        if (Input.GetMouseButtonDown(0))
        {
            playerAnimator.SetTrigger("Hit");
        }
    }
}