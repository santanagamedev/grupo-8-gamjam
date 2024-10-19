using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.RenderGraphModule;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{

    public GameObject botonPause;
    public GameObject menuPausa;
    public GameObject canvasGameOver;
    private bool escPausa=false ;

    public  void Start() { 
        escPausa=false;
        botonPause.SetActive(true);
        menuPausa.SetActive(false);
        canvasGameOver.SetActive(false);

    }
     private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (escPausa){
                Reanudar();
            }else{
                Pausa();
            }
    
        }
        
    }
    // metodo para pausar escena cuando damos boton de pausa 
   public void Pausa ()
    {   escPausa=true;
        Time.timeScale =0f;
        botonPause.SetActive(false);
        menuPausa.SetActive(true);
    }
// metodo para reanudar juego y desactivar menu pausa   
    public void Reanudar ()
    {   escPausa=false;
        botonPause.SetActive(true);
        menuPausa.SetActive(false);

    }
    public void Reiniciar()
    {
        escPausa=false;
        Time.timeScale=1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit(){

        Time.timeScale=1f;
        SceneManager.LoadScene("inicio");
    }

    }
   

