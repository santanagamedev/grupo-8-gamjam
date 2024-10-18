using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSound : ManagerSound
{
    [SerializeField] private AudioClip sound;
    [SerializeField] private float durationEffectSlow;
    [SerializeField] private float volume; 
    void Start()
    {
        base.InitializeAudioSource();
        InitializeAmbientSound();
        base.audioSource.volume = volume;
    }

    private void InitializeAmbientSound()
    {
        if(sound != null)
        {
            base.audioSource.clip = sound;
            base.audioSource.loop =  true;
            base.audioSource.Play();
        }

        

    }

    public void setVolume(float value)
    {
        volume = value;
    }

    public void PauseGame()
    {
        StartCoroutine(IEPauseGame());
    }

    public void ResumeGame()
    {
        StartCoroutine(IEResumeGame());
    }

    IEnumerator IEPauseGame()
    {
        Debug.Log("entra al pause 1/3");

        Time.timeScale = 0; // Pausa completamente el tiempo del juego

        float startPitch = audioSource.pitch;
        float startVolume = audioSource.volume;

        for (float t = 0; t < durationEffectSlow; t += Time.unscaledDeltaTime)
        {
            Debug.Log("entra al pause 2/3");
            audioSource.pitch = Mathf.Lerp(startPitch, 0.5f, t / durationEffectSlow);
            audioSource.volume = Mathf.Lerp(startVolume, 0.2f, t / durationEffectSlow);
            yield return null;
        }
        Debug.Log("entra al pause 3/3");
        audioSource.pitch = 0.5f;
        audioSource.volume = 0.2f;
        audioSource.Pause();
    }


        IEnumerator IEResumeGame()
    {
        Time.timeScale = 1f; // Restaura el tiempo del juego

        audioSource.UnPause();
        float startPitch = audioSource.pitch;
        float startVolume = audioSource.volume;

        for (float t = 0; t < durationEffectSlow; t += Time.unscaledDeltaTime)
        {
            audioSource.pitch = Mathf.Lerp(startPitch, 1f, t / durationEffectSlow);
            audioSource.volume = Mathf.Lerp(startVolume, 1f, t / durationEffectSlow);
            yield return null;
        }

        audioSource.pitch = 1f;
        audioSource.volume = 1f;

    }
}
