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

    public Color hoverColor = new Color(169f, 0f, 20f, 0.8f);

    private int CurrentLink = -1;
    private List<Color32[]> OriginalVertexColors = new List<Color32[]>();


    private void Awake(){
        dialogueText = GetComponent<TextMeshProUGUI>();
    }

    void LateUpdate(){
        var isHoveringOver = TMP_TextUtilities.IsIntersectingRectTransform(dialogueText.rectTransform, Input.mousePosition, null);
        int linkIndex = isHoveringOver ? TMP_TextUtilities.FindIntersectingLink(dialogueText, Input.mousePosition, null) : -1;

       // Clear previous link selection if one existed.
        if( CurrentLink != -1 && linkIndex != CurrentLink ) {
            // Debug.Log("Clear old selection");
            SetLinkToColor(CurrentLink, (linkIdx, vertIdx) => OriginalVertexColors[linkIdx][vertIdx]);
            OriginalVertexColors.Clear();
            CurrentLink = -1;
        }

        // Handle new link selection.
        if( linkIndex != -1 && linkIndex != CurrentLink ) {
            // Debug.Log("New selection");
            CurrentLink = linkIndex;
            OriginalVertexColors = SetLinkToColor(linkIndex, (_linkIdx, _vertIdx) => hoverColor);
        }


    }

    public void OnPointerClick(PointerEventData eventData){
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            int linkIndex = (TMP_TextUtilities.FindIntersectingLink(dialogueText, Input.mousePosition, null));

            if (linkIndex > -1){
                TMP_LinkInfo linkInfo = dialogueText.textInfo.linkInfo[linkIndex];
                string linkId = linkInfo.GetLinkID();
                Debug.Log("You chose: " + linkId + ". Which has linkindex: " + linkIndex);
                //MAKE CHOICE HERE
                DialogueManager.GetInstance().MakeChoice(linkIndex);
            }
            else{
                Debug.Log("Not a link");
            }
        }
    }

    List<Color32[]> SetLinkToColor(int linkIndex, Func<int, int, Color32> colorForLinkAndVert) {
        TMP_LinkInfo linkInfo = dialogueText.textInfo.linkInfo[linkIndex];

        var oldVertColors = new List<Color32[]>(); // store the old character colors

        for( int i = 0; i < linkInfo.linkTextLength; i++ ) { // for each character in the link string
            int characterIndex = linkInfo.linkTextfirstCharacterIndex + i; // the character index into the entire text
            var charInfo = dialogueText.textInfo.characterInfo[characterIndex];
            int meshIndex = charInfo.materialReferenceIndex; // Get the index of the material / sub text object used by this character.
            int vertexIndex = charInfo.vertexIndex; // Get the index of the first vertex of this character.

            Color32[] vertexColors = dialogueText.textInfo.meshInfo[meshIndex].colors32; // the colors for this character
            oldVertColors.Add(vertexColors.ToArray());

            if( charInfo.isVisible ) {
                vertexColors[vertexIndex + 0] = colorForLinkAndVert(i, vertexIndex + 0);
                vertexColors[vertexIndex + 1] = colorForLinkAndVert(i, vertexIndex + 1);
                vertexColors[vertexIndex + 2] = colorForLinkAndVert(i, vertexIndex + 2);
                vertexColors[vertexIndex + 3] = colorForLinkAndVert(i, vertexIndex + 3);
            }
        }

        // Update Geometry
        dialogueText.UpdateVertexData(TMP_VertexDataUpdateFlags.All);

        return oldVertColors;
    }

}
