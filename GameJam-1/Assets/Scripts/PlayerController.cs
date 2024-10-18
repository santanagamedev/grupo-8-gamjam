using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float xMove;
    private float yMove;
    public float speedMoevment = 25.0f;
    private float hit;
    public GameObject playerMesh;
    private Animator playerAnimator;

    private void Start() {
        playerAnimator = GetComponentInChildren<Animator>(); 
    }
    void Update()
    {
        //Movimiento del player con ASWD
        xMove = Input.GetAxisRaw("Horizontal");
        yMove = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector3.right * xMove * speedMoevment * Time.deltaTime );
        transform.Translate(Vector3.forward * yMove * speedMoevment * Time.deltaTime );

        // Rota al player según la dirección en que se mueva
        if (yMove > 0)
        {
            playerMesh.transform.localEulerAngles = new Vector3(0, 180, 0);
        }
        if (yMove < 0)
        {
            playerMesh.transform.localEulerAngles = new Vector3(0, 0, 0);              
        }
        if (xMove > 0)
        {
            playerMesh.transform.localEulerAngles = new Vector3(0, 90, 0);               
        }
        if (xMove < 0)
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
    }
}
