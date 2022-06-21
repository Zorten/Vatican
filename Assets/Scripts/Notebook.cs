using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : Items
{
    public Notebook(){
        itemName = "Notebook";
        inRoomDesc = "It's a notebook you keep around to note any bizarre happenings.";
        pickupText = "You got this Notebook as a gift from the late Pope.";
        invText = "Helpful for logging.";
    }
}
