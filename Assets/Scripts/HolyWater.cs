using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyWater : Items
{
    private bool isFilled = false;
    public void blessWater(){
        isFilled = true;
    }
    public HolyWater(){
        itemName = "Holy Water";
        inRoomDesc = "Liquids of the Lord";
        pickupText = "You splash the water on your face. MMMMMMM refreshing.";
        invText = "Kachow";
    }
}
