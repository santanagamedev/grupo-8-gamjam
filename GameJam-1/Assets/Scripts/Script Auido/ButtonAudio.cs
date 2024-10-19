using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButonAudio : ManagerSound, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    [SerializeField] private Button button;
    [SerializeField] private AudioClip overSound;
    [SerializeField] private AudioClip selectSound;
    [SerializeField] private float volume = 0.5f;

    // Start is called before the first frame update

    void Start()
    {
        button = GetComponent<Button>();
        base.audioSource.volume = volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        OverSound();
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {

    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        SelectSound();
    }

    public void OverSound()
    {
        if(overSound != null)
        {
            audioSource.PlayOneShot(overSound);
        }
        
    }

    public void SelectSound()
    {
        if(selectSound != null)
        {
            audioSource.PlayOneShot(selectSound);
        }
        
    }
}
