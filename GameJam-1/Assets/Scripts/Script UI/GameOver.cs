using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
  public AmbientSound ambientSound;
 private void OnEnable() {
      ambientSound.PauseGame();
}
 public   void Fin ()
  {
       
        Time.timeScale=1f;
        SceneManager.LoadScene("inicio");
  }
}
