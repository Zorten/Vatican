using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HomeAndTime : MonoBehaviour
{
    public Button replenishEnergyButton;
    public Button wasteEnergyButton;
    public Text myText;
    public Text energyText;
    public Text statusText;
    public GeneralThingsThatHappen player;
    public popUpStatus statusScreen;
    private int tripsHome = 0;
    private int days = 1;

    public void buttonClickPos(){
        tripsHome++;
        if(tripsHome >= 4){
            player.SetEnergy(100);
        }else{
            player.AddEnergy(20);
        }
        energyText.text = "Energy: " + player.HowMuchEnergy();
        //statusScreen.popUp();
        //statusScreen.updateText(player.HowMuchEnergy());
        if(tripsHome >= 4){
            tripsHome = 0;
            days++;
            if(days >= 8){
                Debug.Log("Game Over. You die.");
                replenishEnergyButton.onClick.RemoveAllListeners();
                wasteEnergyButton.onClick.RemoveAllListeners();
            }
        }
        myText.text = "Day " + days;
        Debug.Log("ah");
    }

    public void buttonClickNeg(){
        if(player.HowMuchEnergy() > 0){
            statusScreen.popUp();
            statusScreen.updateText(player.HowMuchEnergy());
            player.AddEnergy(-10);
            statusScreen.updateText(player.HowMuchEnergy());
        }
        energyText.text = "Energy: " + player.HowMuchEnergy();
    }

    public void updateStatus(){
        if(player.HowMuchEnergy() > 80){
            statusText.text = "I should get going.";
        }else if(player.HowMuchEnergy() < 80){
            statusText.text = "All this walking around is leaving me a bit tired";
        }else if(player.HowMuchEnergy() < 40){
            statusText.text = "If I don't rest soon, I'll end up just like the pope. Dead.";
        }else if(player.HowMuchEnergy() < 20){
            statusText.text = "Eyelids... heavy....";
        }else{
            statusText.text = "O sweet release of death, whisk me away from this mortal realm";
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        replenishEnergyButton.onClick.AddListener(buttonClickPos);
        wasteEnergyButton.onClick.AddListener(buttonClickNeg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
