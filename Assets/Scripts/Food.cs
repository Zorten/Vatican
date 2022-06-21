using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Items
{
    public Food(){
        itemName = "Food";
        inRoomDesc = "It's a food yo";
        pickupText = "You've obtained: 1x Food yo";
        invText = "You got this food yo in the [Living Room]";
    }
}
