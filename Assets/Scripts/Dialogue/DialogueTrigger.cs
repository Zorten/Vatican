using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class DialogueTrigger : MonoBehaviour, IPointerClickHandler
{
  

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;


    [Header("Icons")]
    [SerializeField] private GameObject StartIcon;
    [SerializeField] private GameObject ContinueIcon;

    private bool cont;

    private void Awake() 
    {
        StartIcon.SetActive(true);
        ContinueIcon.SetActive(false);
        cont = false;
    }

    private void Update() 
    {
        if (cont && !DialogueManager.GetInstance().dialogueIsPlaying) 
        {
            Debug.Log("boutta call dialogue manager");
            if (cont) 
            {
                StartIcon.SetActive(false);
                ContinueIcon.SetActive(true);
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            }
        }
    
    }

    public void OnPointerClick (PointerEventData eventData)
        {
            Debug.Log ("clicked");
            cont = true;
        }
}