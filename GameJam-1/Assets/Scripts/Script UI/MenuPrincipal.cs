using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipal : MonoBehaviour
{
    public GameObject controles; 
      public GameObject menuInicio;
    
    public void StartGame()
    {   
        SceneManager.LoadScene("Nivel-final"); // carga la escena del juego 
        Time.timeScale =1f;

    }
    public void ControlesCanva  ()// este metodo activa el canvas de controles
    {  
        controles.SetActive(true);
        menuInicio.SetActive(false);

        
    }

    public void Quit()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }

}
