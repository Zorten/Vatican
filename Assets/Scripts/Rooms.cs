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

    public void displayItems(){
        //Debug.Log("helo dis works");
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
        displayItems();
    }
    // Start is called before the first frame update
    void Start()
    {
        moveRooms();
    }

    // Update is called once per frame
    void Update()
    {
        //displayItems();
    }
}
