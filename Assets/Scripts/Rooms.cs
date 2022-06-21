using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Rooms : MonoBehaviour
{
    private int positioning = 5;
    [SerializeField] private HomeAndTime whatDay;
    private string location = "First Floor Hallway";
    private Button moveRoomButton;
    private Text currRoomText;
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
    private Items[] firstfloorhallwayobjects = new Items[10];
    private int actualLength = 0;
    
    public void displayItems(){
        //Debug.Log("helo dis works");
        if(location == "First Floor Hallway"){
            for(int i=0; i<actualLength; ++i){
                GameObject button1 = new GameObject();
                button1.AddComponent<Button>().onClick.AddListener(firstfloorhallwayobjects[i].pickupItem);
                //button1.AddComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 5);
                button1.transform.position = new Vector3(0, 0, positioning);
            }
        }
    }
    public void moveRooms(){
        displayItems();
    }
    // Start is called before the first frame update
    void Start()
    {
        moveRooms();
        if(whatDay.getDays() == 1){
            firstfloorhallwayobjects[0] = sCrux;
            actualLength = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //displayItems();
    }
}
