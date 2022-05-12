using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarmaKids : MonoBehaviour
{
    public Button kids;
    public GeneralThingsThatHappen player;
    public HomeAndTime messenger;
    private bool smallActivated = false;
    private bool bigActivated = false;
    private bool silverCrucifix = true;
    [SerializeField] public float timeBetweenCall = 1f;
    // Start is called before the first frame update
    void KarmicJustice(){
        if(silverCrucifix == true){
            player.DecreaseKarma();
            Debug.Log(player.HowMuchKarma());
            if(smallActivated == false && player.HowMuchKarma() <= 90){
                smallActivated = true;
                Debug.Log("The small child is now loose");
            }
            if(bigActivated == false && player.HowMuchKarma() <= 50){
                bigActivated = true;
                Debug.Log("The big child is now loose");
            }
        }
    }

    //void checkIfDown(){
    //    if(){
    //        timeBetweenCall = 1f;
    //        KarmicJustice();
    //    }
    //}

    void touchMouse(){
        if(timeBetweenCall < 0){
            timeBetweenCall = 1f;
            KarmicJustice();
        }else{
            //Debug.Log(timeBetweenCall);
        }
    }
    void Start()
    {
        kids.onClick.AddListener(touchMouse);
    }

    // Update is called once per frame
    void Update()
    {
        timeBetweenCall -= Time.deltaTime;
    }
}
