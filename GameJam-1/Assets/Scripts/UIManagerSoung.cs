using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Timeline.Actions;
using UnityEngine;

public class UIManagerSoung : MonoBehaviour
{
    public UISound uISound;
    public AmbientSound ambientSound;
    public Canvas canvaPause;

    public bool pause = false;

    // Start is called before the first frame update
    void Start()
    {
        uISound = GetComponent<UISound>();
        ambientSound = GetComponent<AmbientSound>();
        canvaPause.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && pause != true)
        {
            Debug.Log("Pause");
            canvaPause.gameObject.SetActive(true);
            ambientSound.PauseGame();
            pause = true;

        }else if(Input.GetKeyDown(KeyCode.Space) && pause == true)
        {
            Debug.Log("Play");
            canvaPause.gameObject.SetActive(false);
            ambientSound.ResumeGame();
            pause = false;
        }

        
    }
}
