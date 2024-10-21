using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI puntosText;  // Referencia al texto de puntos
    public Image barraDeVida;  // Referencia a la barra de vida
    public float vidaActual; // Vida actual del jugador
    public float vidaMax = 1000f; // Vida máxima del jugador
    public float puntos; // Puntos del jugador
     public GameObject gameOver;
     public GameObject canvaPrincipal;
     public TextMeshProUGUI textScore;
   
    void Start()
    {
        vidaActual = vidaMax; // Inicializa la vida actual
        ActualizarTexto(); // Muestra el puntaje al inicio
        ActualizarBarraVida(); // Muestra la barra de vida al inicio
    }

    // Método que suma puntos
    public void SumarPuntos(int puntosEntrada)
    {
        puntos += puntosEntrada;
        ActualizarTexto(); // Actualiza el texto de los puntos
    }

    // Método que actualiza el texto de los puntos
    private void ActualizarTexto()
    {
        puntosText.text = "POINTS: " + puntos.ToString(); // Actualiza el texto en la UI
    }

    // Método que resta vida
    public void RestarVida(float cantidad)
    {
        vidaActual -= cantidad; // Resta la cantidad de vida
        if (vidaActual <= 0)
        {

            vidaActual = 0; // Asegura de que la vida no sea negativa
            gameOver.SetActive(true);
            canvaPrincipal.SetActive(false);
            textScore.text = "SCORE: " + puntos.ToString();
            Time.timeScale =0f;

            
        }
        ActualizarBarraVida(); // Actualiza la barra de vida
    }

    // Método que actualiza la barra de vida
    private void ActualizarBarraVida()
    {
        barraDeVida.fillAmount = vidaActual / vidaMax; // Actualiza la barra de vida
    }

    // Método que se llama cuando un enemigo es destruido
    public void EnemyDestroyed(int puntos)
    {
        SumarPuntos(puntos); // Suma los puntos al Puntaje
    }
    
}