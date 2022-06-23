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

    public void displayItems(){
        //Debug.Log("helo dis works");
        if(whatDay.getDays() == 1){
            nBook.pickupItem();
            hWater.pickupItem();
        }
        switch(location){
            case AllTheRooms.FirstEntrance:
                //show the button
            break;

            case AllTheRooms.FirstHallway:
            break;

            case AllTheRooms.FirstLivingRoom:
            break;

            case AllTheRooms.FirstKitchen:
            break;

            case AllTheRooms.FirstOffice:
            break;

            case AllTheRooms.FirstCloset:
            break;

            case AllTheRooms.FirstBathroom:
            break;

            case AllTheRooms.Basement:
            break;

            case AllTheRooms.SecondHallway:
            break;

            case AllTheRooms.SecondNursery:
            break;

            case AllTheRooms.SecondMasterBedroom:
            break;

            case AllTheRooms.SecondFullBathroom:
            break;

            case AllTheRooms.SecondBalcony:
            break;
        }
    }

    public void moveRooms(){
        everythingElse.SetActive(false);
        roomMenu.SetActive(true);
        displayItems();
    }

    public void travel(string whereTo){
        //location = AllTheRooms. + whereTo;
        Debug.Log(whereTo);
        location = (AllTheRooms)System.Enum.Parse( typeof(AllTheRooms), whereTo );
        currRoomText.text = "Room: " + whereTo;
        everythingElse.SetActive(true);
        roomMenu.SetActive(false);
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
