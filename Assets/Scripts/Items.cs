using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    protected string itemName;
    protected string inRoomDesc;
    protected string pickupText;
    protected string invText;
    protected bool picked_up = false;
    
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
