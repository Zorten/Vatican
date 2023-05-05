using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ItemOpen : MonoBehaviour
{
    [SerializeField] private Button itemButton;
    [SerializeField] private GameObject itemCanvasFullOfButtons;
    [SerializeField] private GameObject individualitemcanvas;
    [SerializeField] private Items whichClicked;
    [SerializeField] private Text nameText;
    [SerializeField] private Text roomDescText;
    [SerializeField] private Text pickupText;
    [SerializeField] private Text invText;
    // Start is called before the first frame update
    public void showObj(){
        itemCanvasFullOfButtons.SetActive(false);
        individualitemcanvas.SetActive(true);
        if(itemButton.name[this.name.Length-1] == '0'){
            whichClicked = new SilverCrux();
        }
        if(this.name[this.name.Length-1] == '1'){
            whichClicked = new Camera();
        }
        if(this.name[this.name.Length-1] == '2'){
            whichClicked = new Thermometer();
        }
        if(this.name[this.name.Length-1] == '3'){
            whichClicked = new TapeRecorder();
        }
        if(this.name[this.name.Length-1] == '4'){
            whichClicked = new Food();
        }
        if(this.name[this.name.Length-1] == '5'){
            whichClicked = new Bedsheets();
        }
        if(this.name[this.name.Length-1] == '6'){
            whichClicked = new WoodCrux();
        }
        if(this.name[this.name.Length-1] == '7'){
            whichClicked = new Notebook();
        }
        if(whichClicked.getPickupStatus() == true){
            nameText.text = whichClicked.getName();
            roomDescText.text = whichClicked.getInRoomDesc();
            pickupText.text = whichClicked.getOnPickupText();
            invText.text = whichClicked.getInventoryText();
        }
    }
    public void Start()
    {
        itemButton.onClick.AddListener(showObj);
        //individualitemcanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
