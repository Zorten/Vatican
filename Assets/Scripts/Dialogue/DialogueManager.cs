using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour//, IPointerClickHandler
{

    [Header("Params")]
    [SerializeField] private float typingSpeed = 0.06f;

    [Header("Load Globals JSON")]
    [SerializeField] private TextAsset loadGlobalsJSON;

    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private GameObject continueIcon;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private GameObject CurrentIcon;

    [SerializeField] private TextMeshProUGUI roomNameText;

    private Animator layoutAnimator;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;


    private Story currentStory;
    public bool dialogueIsPlaying { get; private set; }

    private bool canContinueToNextLine = false;
    private bool boxChoices = true; 

    private Coroutine displayLineCoroutine;


    private static DialogueManager instance;

    private const string LAYOUT_TAG = "layout";

    private const string ROOM_TAG = "room";

    private const string CHOICE_TAG = "choice";

    private DialogueVariables dialogueVariables;

    private void Awake() 
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Manager in the scene");
        }
        instance = this;

        dialogueVariables = new DialogueVariables(loadGlobalsJSON);
    }

    public static DialogueManager GetInstance() 
    {
        return instance;
    }

    private void Start() 
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(true);

        //get the layout animator
        layoutAnimator = dialoguePanel.GetComponent<Animator>();

        
        // get all of the choices text 
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices) 
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
        
    }

    private void Update() 
    {
        // return right away if dialogue isn't playing
        if (!dialogueIsPlaying) 
        {
            return;
        }

        // handle continuing to the next line in the dialogue when submit is pressed
        // NOTE: The 'currentStory.currentChoiecs.Count == 0' part was to fix a bug after the Youtube video was made
        if (canContinueToNextLine 
            && currentStory.currentChoices.Count == 0 
            && InputManager.GetInstance().GetSubmitPressed())
        {
            ContinueStory();
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON) 
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        
        dialogueVariables.StartListening(currentStory);
        currentStory.BindExternalFunction ("setButtonActive", () => {
            CurrentIcon.SetActive(true);
            continueIcon.SetActive(false);
        });

        ContinueStory();
    }

    private IEnumerator ExitDialogueMode() 
    {
        yield return new WaitForSeconds(0.2f);

        dialogueVariables.StopListening(currentStory);


        dialogueIsPlaying = false;
        dialoguePanel.SetActive(true);
        dialogueText.text = "";
    }

    private void ContinueStory() 
    {
        if (currentStory.canContinue) 
        {
            // set text for the current dialogue line
            if (displayLineCoroutine != null) 
            {
                StopCoroutine(displayLineCoroutine);
            }
            displayLineCoroutine = StartCoroutine(DisplayLine(currentStory.Continue()));

            //Handle tags
            HandleTags(currentStory.currentTags);

        }
        else 
        {
            StartCoroutine(ExitDialogueMode());
        }
    }

    private void HandleTags(List<string> currentTags)
    {
        //Loop through each tag and handle accordingly
        foreach (string tag in currentTags)
        {
            //parse the tag
            string[] splitTag = tag.Split(':');
            if (splitTag.Length != 2)
            {
                Debug.LogError("Tag could not be parsed appropriately: " + tag);
            }
            string tagkey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();

            switch (tagkey)
            {
                case LAYOUT_TAG:
                    layoutAnimator.Play(tagValue);
                    break;
                
                case ROOM_TAG:
                    roomNameText.text = tagValue;
                    break;

                case CHOICE_TAG:
                    if (tagValue == "link"){
                        boxChoices = false;
                    }
                    else{
                        boxChoices = true;
                    }
                    break;

                default:
                    Debug.LogWarning("Tag came in but not handled: " + tag);
                    break;
            }
        }
    }

    private IEnumerator DisplayLine(string line) 
    {
        // empty the dialogue text
        dialogueText.text = "";
        // hide items while text is typing
       continueIcon.SetActive(false);
       HideChoices();

        canContinueToNextLine = false;

        bool isAddingRichTextTag = false;

        // display each letter one at a time
        foreach (char letter in line.ToCharArray())
        {
            // if the submit button is pressed, finish up displaying the line right away
            if (InputManager.GetInstance().GetSubmitPressed()) 
            {
                dialogueText.text = line;
                break;
            }

            // check for rich text tag, if found, add it without waiting
            if (letter == '<' || isAddingRichTextTag) 
            {
                isAddingRichTextTag = true;
                dialogueText.text += letter;
                if (letter == '>')
                {
                    isAddingRichTextTag = false;
                }
            }
            // if not rich text, add the next letter and wait a small time
            else 
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }
        }

        continueIcon.SetActive(true);
        //display choices, if any, and if in dialogue mode

        if (boxChoices){
            DisplayChoices();
        }
        canContinueToNextLine = true;

    }

     private void HideChoices() 
    {
        foreach (GameObject choiceButton in choices) 
        {
            choiceButton.SetActive(false);
        }
    }

    private void DisplayChoices() 
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        // defensive check to make sure our UI can support the number of choices coming in
        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("More choices were given than the UI can support. Number of choices given: " 
                + currentChoices.Count);
        }

        int index = 0;
        // enable and initialize the choices up to the amount of choices for this line of dialogue
        foreach(Choice choice in currentChoices) 
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        // go through the remaining choices the UI supports and make sure they're hidden
        for (int i = index; i < choices.Length; i++) 
        {
            choices[i].gameObject.SetActive(false);
        }

        StartCoroutine(SelectFirstChoice());
    }

    private IEnumerator SelectFirstChoice() 
    {
        // Event System requires we clear it first, then wait
        // for at least one frame before we set the current selected object.
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    public void MakeChoice(int choiceIndex)
    {
        if (canContinueToNextLine)
        {
            currentStory.ChooseChoiceIndex(choiceIndex);
            InputManager.GetInstance().RegisterSubmitPressed(); // this is specific to my InputManager script
            ContinueStory();

        }
    }

    public Ink.Runtime.Object GetVariableState(string variableName) 
    {
        Ink.Runtime.Object variableValue = null;
        dialogueVariables.variables.TryGetValue(variableName, out variableValue);
        if (variableValue == null) 
        {
            Debug.LogWarning("Ink Variable was found to be null: " + variableName);
        }
        return variableValue;
    }

    // public void OnPointerClick(PointerEventData eventData){
    //     if (eventData.button == PointerEventData.InputButton.Left)
    //     {
    //         int linkIndex = (TMP_TextUtilities.FindIntersectingLink(dialogueText, Input.mousePosition, null));

    //         if (linkIndex > -1){
    //             TMP_LinkInfo linkInfo = dialogueText.textInfo.linkInfo[linkIndex];
    //             string linkId = linkInfo.GetLinkID();
    //             Debug.Log("You chose: " + linkId + ". Which has linkindex: " + linkIndex);
    //             //MAKE CHOICE HERE -- how do I pass this onto DialogueManager? linkIndex will correspond with choiceIndex 

    //         }
    //         else{
    //             Debug.Log("Not a link");
    //         }
    //     }
    // }

}