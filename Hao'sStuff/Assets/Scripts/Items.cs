using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    private string itemName;
    private string inRoomDesc;
    private string pickupText;
    private string invText;
    private bool picked_up = false;
    
    public string getName(){
        return itemName;
    }
    public void setName(string name_){
        itemName = name_;
    }
    public string getInRoomDesc(){
        return inRoomDesc;
    }
    public void setInRoomDesc(string desc_){
        inRoomDesc = desc_;
    }
    public string getOnPickupText(){
        return pickupText;
    }
    public void setOnPickupText(string pickup_){
        pickupText = pickup_;
    }
    public string getInventoryText(){
        return invText;
    }
    public void setInventoryText(string invText_){
        invText = invText_;
    }
    public void pickupItem(){
        picked_up = true;
    }
    public bool getPickupStatus(){
        return picked_up;
    }
};

public class SilverCrux : Items
{
    public SilverCrux(){
        setName("Silver Crucifix");
        setInRoomDesc("It's a silver crux yo");
        setOnPickupText("You've obtained: 1x Silver Crux yo");
        setInventoryText("You got this Silver Crux yo in the [Living Room]");
    }
};
public class Camera : Items
{
    public Camera(){
        setName("Camera");
        setInRoomDesc("It's a camera yo. You probably need film.");
        setOnPickupText("You've obtained: 1x Camera yo");
        setInventoryText("You got this Camera yo in the [Office]");
    }
};
public class Thermometer : Items
{
    public Thermometer(){
        setName("Thermometer");
        setInRoomDesc("It's a thermometer yo");
        setOnPickupText("You've obtained: 1x Thermometer yo");
        setInventoryText("You got this Thermometer yo in the [Living Room]");
    }
};
public class TapeRecorder : Items
{
    public TapeRecorder(){
        setName("Tape Recorder");
        setInRoomDesc("It's a tape recorder yo");
        setOnPickupText("You've obtained: 1x Tape Recorder yo");
        setInventoryText("You got this Tape Recorder yo in the [Living Room]");
    }
};
public class Food : Items
{
    public Food(){
        setName("Food");
        setInRoomDesc("It's a food yo");
        setOnPickupText("You've obtained: 1x food yo");
        setInventoryText("You got this food yo in the [Kitchen]");
    }
};
public class Bedsheets : Items
{
    public Bedsheets(){
        setName("Bedsheets");
        setInRoomDesc("It's a bedsheets yo");
        setOnPickupText("You've obtained: 1x Bedsheets yo");
        setInventoryText("You got this Bedsheets yo in the [Living Room]");
    }
};
public class WoodCrux : Items
{
    public WoodCrux(){
        setName("Wooden Crucifix");
        setInRoomDesc("It's a wooden crux yo");
        setOnPickupText("You've obtained: 1x Wooden Crux yo");
        setInventoryText("You got this Wooden Crux yo in the [Living Room]");
    }
};
public class Notebook : Items
{
    public Notebook(){
        setName("Notebook");
        setInRoomDesc("It's a notebook you keep around to note any bizarre happenings.");
        setOnPickupText("You got this Notebook as a gift from the late Pope.");
        setInventoryText("Helpful for logging.");
    }
};
