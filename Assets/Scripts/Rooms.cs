using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Rooms : MonoBehaviour
{
    private string location = "First Floor Hallway";
    private Button moveRoomButton;
    private Text currRoomText;
    private Items sCrux = new SilverCrux();
    private Items cam = new Camera();
    private Items therM = new Thermometer();
    private Items tRec = new TapeRecorder();
    private Items food = new Food();
    private Items bSheet = new Bedsheets();
    private Items wCrux = new WoodCrux();
    private Items nBook = new Notebook();
    public void displayItems(){
        if(location == "First Floor Hallway"){
            
        }
    }
    public void moveRooms(){

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
