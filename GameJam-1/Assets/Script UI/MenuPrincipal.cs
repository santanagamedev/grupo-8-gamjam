using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipal : MonoBehaviour
{
    public GameObject controles; 
      public GameObject menuInicio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {   SceneManager.LoadScene("CanvasUI");
        //SceneManager.LoadScene("Nivel-final");
    }
    public void ControlesCanva  ()
    {  
        controles.SetActive(true);
        menuInicio.SetActive(false);

        
    }

    public void Quit()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
