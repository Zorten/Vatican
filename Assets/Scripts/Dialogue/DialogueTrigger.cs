using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class DialogueTrigger : MonoBehaviour//, IPointerClickHandler
{
  

     [Header("Ink JSON Files")]
     [SerializeField] private TextAsset[] inkJSON;
    //[Header("Ink JSON")]
    //[SerializeField] private TextAsset inkJSON;


    [Header("Icons")]
   // [SerializeField] private GameObject StartIcon;
    [SerializeField] private GameObject ContinueIcon;
    [SerializeField] private GameObject CurrentIcon;

    private bool cont;
    int index = 0;
    private void Awake() 
    {
        CurrentIcon.SetActive(true);
        ContinueIcon.SetActive(false);
        cont = false;
        StartCoroutine(SelectFirstButton());
    }

    private void Update() 
    {
        if (cont && !DialogueManager.GetInstance().dialogueIsPlaying) 
        {
            cont = false;
            CurrentIcon.SetActive(false);
            ContinueIcon.SetActive(true);
            DialogueManager.GetInstance().EnterDialogueMode(inkJSON[index]);
            index++;
        }
    
    }

    public void Click()
    {
        if(!DialogueManager.GetInstance().dialogueIsPlaying){
            InputManager.GetInstance().RegisterSubmitPressed();
            cont = true;
            Debug.Log("Click detected");
        }
        
    }




        private IEnumerator SelectFirstButton() 
    {
        // Event System requires we clear it first, then wait
        // for at least one frame before we set the current selected object.
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(CurrentIcon.gameObject);
    }
}