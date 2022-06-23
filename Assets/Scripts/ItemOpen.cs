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

    [SerializeField] private SilverCrux sCrux;
    [SerializeField] private Camera cam;
    [SerializeField] private Thermometer therM;
    [SerializeField] private TapeRecorder tRec;
    [SerializeField] private Food food;
    [SerializeField] private Bedsheets bSheet;
    [SerializeField] private WoodCrux wCrux;
    [SerializeField] private Notebook nBook;
    [SerializeField] private Film film;
    [SerializeField] private HolyWater hWater;
    // Start is called before the first frame update
    public void showObj(){
        itemCanvasFullOfButtons.SetActive(false);
        individualitemcanvas.SetActive(true);
        if(itemButton.name[this.name.Length-1] == '0'){
            whichClicked = sCrux;
        }
        else if(this.name[this.name.Length-1] == '1'){
            whichClicked = cam;
        }
        else if(this.name[this.name.Length-1] == '2'){
            whichClicked = therM;
        }
        else if(this.name[this.name.Length-1] == '3'){
            whichClicked = tRec;
        }
        else if(this.name[this.name.Length-1] == '4'){
            whichClicked = food;
        }
        else if(this.name[this.name.Length-1] == '5'){
            whichClicked = bSheet;
        }
        else if(this.name[this.name.Length-1] == '6'){
            whichClicked = wCrux;
        }
        else if(this.name[this.name.Length-1] == '7'){
            whichClicked = nBook;
        }
        else if(this.name[this.name.Length-1] == '8'){
            whichClicked = film;
        }
        else if(this.name[this.name.Length-1] == '9'){
            whichClicked = hWater;
        }

        if(whichClicked.getPickupStatus() == true){
            nameText.text = whichClicked.getName();
            roomDescText.text = whichClicked.getInRoomDesc();
            pickupText.text = whichClicked.getOnPickupText();
            invText.text = whichClicked.getInventoryText();
        }else{
            nameText.text = "Unknown";
            roomDescText.text = "Unknown";
            pickupText.text = "Unknown";
            invText.text = "Unknown";
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
