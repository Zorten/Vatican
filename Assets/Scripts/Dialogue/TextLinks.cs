using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;


public class TextLinks : MonoBehaviour, IPointerClickHandler
{
    private TextMeshProUGUI dialogueText;

    private void Awake(){
        dialogueText = GetComponent<TextMeshProUGUI>();
    }

    public void OnPointerClick(PointerEventData eventData){
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            int linkIndex = (TMP_TextUtilities.FindIntersectingLink(dialogueText, Input.mousePosition, null));

            if (linkIndex > -1){
                TMP_LinkInfo linkInfo = dialogueText.textInfo.linkInfo[linkIndex];
                string linkId = linkInfo.GetLinkID();
                Debug.Log("You chose: " + linkId + ". Which has linkindex: " + linkIndex);
                //MAKE CHOICE HERE -- how do I pass this onto DialogueManager? linkIndex will correspond with choiceIndex 

            }
            else{
                Debug.Log("Not a link");
            }
        }
    }
}
