using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public enum AllTheRooms {FirstEntrance, FirstHallway, FirstLivingRoom, FirstKitchen, FirstOffice, FirstCloset, FirstBathroom, Basement, SecondHallway, SecondNursery, SecondMasterBedroom, SecondFullBathroom, SecondBalcony}

public class Rooms : MonoBehaviour
{
    private int positioning = 5;
    [SerializeField] private HomeAndTime whatDay;
    private AllTheRooms location = AllTheRooms.FirstEntrance;
    [SerializeField] private Button moveRoomButton;
    [SerializeField] private Text currRoomText;
    // private Items sCrux = new SilverCrux();
    // private Items cam = new Camera();
    // private Items therM = new Thermometer();
    // private Items tRec = new TapeRecorder();
    // private Items food = new Food();
    // private Items bSheet = new Bedsheets();
    // private Items wCrux = new WoodCrux();
    // private Items nBook = new Notebook();
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

    [SerializeField] private GameObject roomMenu;
    [SerializeField] private GameObject everythingElse;

    [SerializeField] private Button fE;
    [SerializeField] private Button fH;
    [SerializeField] private Button fLR;
    [SerializeField] private Button fK;
    [SerializeField] private Button fO;
    [SerializeField] private Button fC;
    [SerializeField] private Button fB;
    [SerializeField] private Button Bas;
    [SerializeField] private Button sH;
    [SerializeField] private Button sN;
    [SerializeField] private Button sMB;
    [SerializeField] private Button sFB;
    [SerializeField] private Button sB;

    [SerializeField] private Button pickupButton1;
    [SerializeField] private Button pickupButton2;
    [SerializeField] private Text pickupButton1Text;
    [SerializeField] private Text pickupButton2Text;

    public void displayItems(){
        //Debug.Log("helo dis works");
        if(whatDay.getDays() == 1){
            nBook.pickupItem();
            hWater.pickupItem();
        }
        Debug.Log(location);
        switch(location){
            case (AllTheRooms)0:
                //show the button
                pickupButton1.onClick.RemoveAllListeners();
                pickupButton2.onClick.RemoveAllListeners();
                pickupButton1Text.text = "";
                pickupButton2Text.text = "";
                fE.gameObject.SetActive(false);
                fH.gameObject.SetActive(true);
                fLR.gameObject.SetActive(false);
                fK.gameObject.SetActive(false);
                fO.gameObject.SetActive(false);
                fC.gameObject.SetActive(false);
                fB.gameObject.SetActive(false);
                Bas.gameObject.SetActive(false);
                sH.gameObject.SetActive(false);
                sN.gameObject.SetActive(false);
                sMB.gameObject.SetActive(false);
                sFB.gameObject.SetActive(false);
                sB.gameObject.SetActive(false);
            break;

            case (AllTheRooms)1:
                pickupButton1.onClick.RemoveAllListeners();
                pickupButton2.onClick.RemoveAllListeners();
                pickupButton1Text.text = "";
                pickupButton2Text.text = "";
                fE.gameObject.SetActive(true);
                fH.gameObject.SetActive(false);
                fLR.gameObject.SetActive(true);
                fK.gameObject.SetActive(true);
                fO.gameObject.SetActive(true);
                fC.gameObject.SetActive(true);
                fB.gameObject.SetActive(true);
                Bas.gameObject.SetActive(true);
                sH.gameObject.SetActive(true);
                sN.gameObject.SetActive(false);
                sMB.gameObject.SetActive(false);
                sFB.gameObject.SetActive(false);
                sB.gameObject.SetActive(false);
            break;

            case (AllTheRooms)2:
                pickupButton1.onClick.RemoveAllListeners();
                pickupButton2.onClick.RemoveAllListeners();
                pickupButton1Text.text = "";
                pickupButton2Text.text = "";
                fE.gameObject.SetActive(false);
                fH.gameObject.SetActive(true);
                fLR.gameObject.SetActive(false);
                fK.gameObject.SetActive(false);
                fO.gameObject.SetActive(false);
                fC.gameObject.SetActive(false);
                fB.gameObject.SetActive(false);
                Bas.gameObject.SetActive(false);
                sH.gameObject.SetActive(false);
                sN.gameObject.SetActive(false);
                sMB.gameObject.SetActive(false);
                sFB.gameObject.SetActive(false);
                sB.gameObject.SetActive(false);
            break;

            case (AllTheRooms)3:
                pickupButton1.onClick.RemoveAllListeners();
                pickupButton2.onClick.RemoveAllListeners();
                if(!food.getPickupStatus()){
                    pickupButton1.onClick.AddListener(delegate{pickupTheActualItems(pickupButton1Text, food);});
                    pickupButton1Text.text = "Pick up Food.";
                }
                if(!hWater.getPickupStatus()){
                    pickupButton2.onClick.AddListener(delegate{pickupTheActualItems(pickupButton2Text, hWater);});
                    pickupButton2Text.text = "Pick up Empty Bottle.";
                }
                fE.gameObject.SetActive(false);
                fH.gameObject.SetActive(true);
                fLR.gameObject.SetActive(false);
                fK.gameObject.SetActive(false);
                fO.gameObject.SetActive(false);
                fC.gameObject.SetActive(false);
                fB.gameObject.SetActive(false);
                Bas.gameObject.SetActive(false);
                sH.gameObject.SetActive(false);
                sN.gameObject.SetActive(false);
                sMB.gameObject.SetActive(false);
                sFB.gameObject.SetActive(false);
                sB.gameObject.SetActive(false);
            break;

            case (AllTheRooms)4:
                pickupButton1.onClick.RemoveAllListeners();
                pickupButton2.onClick.RemoveAllListeners();
                if(!cam.getPickupStatus()){
                    pickupButton1.onClick.AddListener(delegate{pickupTheActualItems(pickupButton1Text ,cam);});
                    pickupButton1Text.text = "Pick up Camera.";
                }
                pickupButton2Text.text = "";
                fE.gameObject.SetActive(false);
                fH.gameObject.SetActive(true);
                fLR.gameObject.SetActive(false);
                fK.gameObject.SetActive(false);
                fO.gameObject.SetActive(false);
                fC.gameObject.SetActive(false);
                fB.gameObject.SetActive(false);
                Bas.gameObject.SetActive(false);
                sH.gameObject.SetActive(false);
                sN.gameObject.SetActive(false);
                sMB.gameObject.SetActive(false);
                sFB.gameObject.SetActive(false);
                sB.gameObject.SetActive(false);
            break;

            case (AllTheRooms)5:
                pickupButton1.onClick.RemoveAllListeners();
                pickupButton2.onClick.RemoveAllListeners();
                pickupButton1Text.text = "";
                pickupButton2Text.text = "";
                fE.gameObject.SetActive(false);
                fH.gameObject.SetActive(true);
                fLR.gameObject.SetActive(false);
                fK.gameObject.SetActive(false);
                fO.gameObject.SetActive(false);
                fC.gameObject.SetActive(false);
                fB.gameObject.SetActive(false);
                Bas.gameObject.SetActive(false);
                sH.gameObject.SetActive(false);
                sN.gameObject.SetActive(false);
                sMB.gameObject.SetActive(false);
                sFB.gameObject.SetActive(false);
                sB.gameObject.SetActive(false);
            break;

            case (AllTheRooms)6:
                pickupButton1.onClick.RemoveAllListeners();
                pickupButton2.onClick.RemoveAllListeners();
                pickupButton1Text.text = "";
                pickupButton2Text.text = "";
                fE.gameObject.SetActive(false);
                fH.gameObject.SetActive(true);
                fLR.gameObject.SetActive(false);
                fK.gameObject.SetActive(false);
                fO.gameObject.SetActive(false);
                fC.gameObject.SetActive(false);
                fB.gameObject.SetActive(false);
                Bas.gameObject.SetActive(false);
                sH.gameObject.SetActive(false);
                sN.gameObject.SetActive(false);
                sMB.gameObject.SetActive(false);
                sFB.gameObject.SetActive(false);
                sB.gameObject.SetActive(false);
            break;

            case (AllTheRooms)7:
                pickupButton1.onClick.RemoveAllListeners();
                pickupButton2.onClick.RemoveAllListeners();
                pickupButton1Text.text = "";
                pickupButton2Text.text = "";
                fE.gameObject.SetActive(false);
                fH.gameObject.SetActive(true);
                fLR.gameObject.SetActive(false);
                fK.gameObject.SetActive(false);
                fO.gameObject.SetActive(false);
                fC.gameObject.SetActive(false);
                fB.gameObject.SetActive(false);
                Bas.gameObject.SetActive(false);
                sH.gameObject.SetActive(false);
                sN.gameObject.SetActive(false);
                sMB.gameObject.SetActive(false);
                sFB.gameObject.SetActive(false);
                sB.gameObject.SetActive(false);
            break;

            case (AllTheRooms)8:
                pickupButton1.onClick.RemoveAllListeners();
                pickupButton2.onClick.RemoveAllListeners();
                pickupButton1Text.text = "";
                pickupButton2Text.text = "";
                fE.gameObject.SetActive(false);
                fH.gameObject.SetActive(true);
                fLR.gameObject.SetActive(false);
                fK.gameObject.SetActive(false);
                fO.gameObject.SetActive(false);
                fC.gameObject.SetActive(false);
                fB.gameObject.SetActive(false);
                Bas.gameObject.SetActive(false);
                sH.gameObject.SetActive(false);
                sN.gameObject.SetActive(true);
                sMB.gameObject.SetActive(true);
                sFB.gameObject.SetActive(true);
                sB.gameObject.SetActive(true);
            break;

            case (AllTheRooms)9:
                pickupButton1.onClick.RemoveAllListeners();
                pickupButton2.onClick.RemoveAllListeners();
                if(!sCrux.getPickupStatus()){
                    pickupButton1.onClick.AddListener(delegate{pickupTheActualItems(pickupButton1Text ,sCrux);});
                    pickupButton1Text.text = "Pick up Silver Crucifix.";
                }
                pickupButton2Text.text = "";
                fE.gameObject.SetActive(false);
                fH.gameObject.SetActive(false);
                fLR.gameObject.SetActive(false);
                fK.gameObject.SetActive(false);
                fO.gameObject.SetActive(false);
                fC.gameObject.SetActive(false);
                fB.gameObject.SetActive(false);
                Bas.gameObject.SetActive(false);
                sH.gameObject.SetActive(true);
                sN.gameObject.SetActive(false);
                sMB.gameObject.SetActive(false);
                sFB.gameObject.SetActive(false);
                sB.gameObject.SetActive(false);
            break;

            case (AllTheRooms)10:
                pickupButton1.onClick.RemoveAllListeners();
                pickupButton2.onClick.RemoveAllListeners();
                if(!bSheet.getPickupStatus()){
                    pickupButton1.onClick.AddListener(delegate{pickupTheActualItems(pickupButton1Text ,bSheet);});
                    pickupButton1Text.text = "Pick up Bedsheets.";
                }
                if(!wCrux.getPickupStatus()){
                    pickupButton2.onClick.AddListener(delegate{pickupTheActualItems(pickupButton2Text ,wCrux);});
                    pickupButton2Text.text = "Pick up Wooden Crucifix.";
                }
                fE.gameObject.SetActive(false);
                fH.gameObject.SetActive(false);
                fLR.gameObject.SetActive(false);
                fK.gameObject.SetActive(false);
                fO.gameObject.SetActive(false);
                fC.gameObject.SetActive(false);
                fB.gameObject.SetActive(false);
                Bas.gameObject.SetActive(false);
                sH.gameObject.SetActive(true);
                sN.gameObject.SetActive(false);
                sMB.gameObject.SetActive(false);
                sFB.gameObject.SetActive(false);
                sB.gameObject.SetActive(false);
            break;

            case (AllTheRooms)11:
                pickupButton1.onClick.RemoveAllListeners();
                pickupButton2.onClick.RemoveAllListeners();
                pickupButton1Text.text = "";
                pickupButton2Text.text = "";
                fE.gameObject.SetActive(false);
                fH.gameObject.SetActive(false);
                fLR.gameObject.SetActive(false);
                fK.gameObject.SetActive(false);
                fO.gameObject.SetActive(false);
                fC.gameObject.SetActive(false);
                fB.gameObject.SetActive(false);
                Bas.gameObject.SetActive(false);
                sH.gameObject.SetActive(true);
                sN.gameObject.SetActive(false);
                sMB.gameObject.SetActive(false);
                sFB.gameObject.SetActive(false);
                sB.gameObject.SetActive(false);
            break;

            case (AllTheRooms)12:
                pickupButton1.onClick.RemoveAllListeners();
                pickupButton2.onClick.RemoveAllListeners();
                if(!therM.getPickupStatus()){
                    pickupButton1.onClick.AddListener(delegate{pickupTheActualItems(pickupButton1Text ,therM);});
                    pickupButton1Text.text = "Pick up Thermometer.";
                }
                pickupButton2Text.text = "";
                fE.gameObject.SetActive(false);
                fH.gameObject.SetActive(false);
                fLR.gameObject.SetActive(false);
                fK.gameObject.SetActive(false);
                fO.gameObject.SetActive(false);
                fC.gameObject.SetActive(false);
                fB.gameObject.SetActive(false);
                Bas.gameObject.SetActive(false);
                sH.gameObject.SetActive(true);
                sN.gameObject.SetActive(false);
                sMB.gameObject.SetActive(false);
                sFB.gameObject.SetActive(false);
                sB.gameObject.SetActive(false);
            break;
        }
    }

    public void pickupTheActualItems(Text theButton, Items whatItem){
        if(whatItem.getPickupStatus()){
            theButton.text = "";
        }else{
            whatItem.pickupItem();
            theButton.text = "";
        }
    }

    public void moveRooms(){
        if(everythingElse.activeInHierarchy){
            everythingElse.SetActive(false);
            roomMenu.SetActive(true);
            displayItems();
        }else{
            everythingElse.SetActive(true);
            roomMenu.SetActive(false);
        }
    }

    public void travel(string whereTo){
        //location = AllTheRooms. + whereTo;
        //Debug.Log(whereTo);
        location = (AllTheRooms)System.Enum.Parse( typeof(AllTheRooms), whereTo );
        currRoomText.text = "Room: " + whereTo;
        everythingElse.SetActive(true);
        roomMenu.SetActive(false);
        displayItems();
    }
    // Start is called before the first frame update
    void Start()
    {
        roomMenu.SetActive(false);
        displayItems();
        moveRoomButton.onClick.AddListener(moveRooms);
        fE.onClick.AddListener(delegate{travel(fE.name);});
        fH.onClick.AddListener(delegate{travel(fH.name);});
        fLR.onClick.AddListener(delegate{travel(fLR.name);});
        fK.onClick.AddListener(delegate{travel(fK.name);});
        fO.onClick.AddListener(delegate{travel(fO.name);});
        fC.onClick.AddListener(delegate{travel(fC.name);});
        fB.onClick.AddListener(delegate{travel(fB.name);});
        Bas.onClick.AddListener(delegate{travel(Bas.name);});
        sH.onClick.AddListener(delegate{travel(sH.name);});
        sN.onClick.AddListener(delegate{travel(sN.name);});
        sMB.onClick.AddListener(delegate{travel(sMB.name);});
        sFB.onClick.AddListener(delegate{travel(sFB.name);});
        sB.onClick.AddListener(delegate{travel(sB.name);});
    }

    // Update is called once per frame
    void Update()
    {
        //displayItems();
    }
}
