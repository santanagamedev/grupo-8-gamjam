using UnityEngine;

public class PlayerControllerRb : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    public GameObject playerMesh;
    private Animator playerAnimator;

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
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed;

        // Aplicar el movimiento en la dirección local del personaje
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);      

        // Rota al player según la dirección en que se mueva
        if (moveVertical > 0)
        {
            playerMesh.transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        if (moveVertical < 0)
        {
            playerMesh.transform.localEulerAngles = new Vector3(0, 180, 0);              
        }
        if (moveHorizontal > 0)
        {
            playerMesh.transform.localEulerAngles = new Vector3(0, 90, 0);               
        }
        if (moveHorizontal < 0)
        {
            playerMesh.transform.localEulerAngles = new Vector3(0, 270, 0);               
        }


        // Cambia la animadion de Idle a Running si de oprime alnga de las teclas ASWD
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D))
        {
            playerAnimator.SetBool("Running", true);
        }
        else
        {
            playerAnimator.SetBool("Running", false);            
        }

        // Animacion y acccion de golpear
        if (Input.GetMouseButtonDown(0))
        {
            playerAnimator.SetTrigger("Hit");
        }

    }
}