using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISound : ManagerSound
{
    [SerializeField] private AudioClip[] selectSound;
    [SerializeField] private AudioClip[] exitSound;
    // Start is called before the first frame update
    public void PlaySelectSound()
    {
        if(selectSound != null && selectSound.Length != 0)
        {
            audioSource.PlayOneShot(selectSound[Random.Range(0, selectSound.Length)]);
        }
    }

    public void PlayExitSound()
    {
        if(exitSound != null && exitSound.Length != 0)
        {
            audioSource.PlayOneShot(exitSound[Random.Range(0, exitSound.Length)]);
        }
    }

}
