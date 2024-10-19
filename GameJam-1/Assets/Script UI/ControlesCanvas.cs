using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesCanvas : MonoBehaviour
{   public GameObject controles; 
    public GameObject menuInicio;
    // Start is called before the first frame update
    void Start()
    {
        controles.SetActive(false);
    }
    public void XSalir  ()
    {  
        menuInicio.SetActive(true);
        controles.SetActive(false);
       
        
    }
    
   }
