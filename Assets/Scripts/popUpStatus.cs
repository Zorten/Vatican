using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class popUpStatus : MonoBehaviour
{
    public SpriteRenderer background;
    public Text status;
    public GameObject statusCanvas;
    public GameObject inventoryThing;
    public Button closeStatus;
    public GameObject actualGame;
    private string[] flavor1 = new string[5] {"I should get going.", "The night is still young.", "Detectiving.", "Kachow.", "<insert catchphrase>"};
    private string[] flavor2 = new string[5] {"All this walking around is leaving me a bit tired", "Whew.. gotta catch my breath..", "I could really go for some pasta right about now...", "*Stretching noises", "<insert catchphrase2>"};
    private string[] flavor3 = new string[5] {"If I don't rest soon, I'll end up just like the pope. Dead.", "*coughs up blood", "I hunger...", "*coughs up even more blood", "<insert catchphrase3>"};
    private string[] flavor4 = new string[5] {"Eyelids... heavy....", "My legs... fail me...", "...", "*coughs up even more blood (more than last time)", "<insert catchphrase4>"};
    private string[] flavor5 = new string[5] {"O sweet release of death, whisk me away from this mortal realm", "I am die", "Club Penguin is kil", "*coughs up even more blood (even more than last time)", "<insert catchphrase5>"};
    public void updateText(int energy){
        int randomPhraseGen = Random.Range(0,5);
        if(energy > 80){
            status.text = flavor1[randomPhraseGen];
        }else if(energy > 60){
            status.text = flavor2[randomPhraseGen];
        }else if(energy > 40){
            status.text = flavor3[randomPhraseGen];
        }else if(energy > 20){
            status.text = flavor4[randomPhraseGen];
        }else{
            status.text = flavor5[randomPhraseGen];
        }
        status.text += "\n Energy - 10";
    }

    public void popUp(){
        statusCanvas.SetActive(true);
        background.sortingOrder = 1;
        actualGame.SetActive(false);
        inventoryThing.SetActive(false);
    }

    public void closePopUp(){
        statusCanvas.SetActive(false);
        background.sortingOrder = -1;
        actualGame.SetActive(true);
        inventoryThing.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        statusCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
