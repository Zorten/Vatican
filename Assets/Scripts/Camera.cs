using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : Items
{
    public Camera(){
        itemName = "Camera";
        inRoomDesc = "It's a camera yo. You probably need film.";
        pickupText = "You've obtained: 1x Camera yo";
        invText = "You got this Camera yo in the [Office]";
    }
}
