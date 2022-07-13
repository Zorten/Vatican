using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralThingsThatHappen : MonoBehaviour
{
    [SerializeField] private int Energy = 100;
    public int EnergyAdd = 20;
    public int KarmaDown = 10;
    private int criteriaLeft = 6;
    private Rooms currRoom;
    [SerializeField] private int Karma = 100;
    // Start is called before the first frame update
    public void AddEnergy(int n){
        Energy += n;
    }

    public void SetEnergy(int n){
        Energy = n;
    }

    public void DecreaseKarma(){
        Karma -= KarmaDown;
    }

    public int HowMuchEnergy(){
        return Energy;
    }

    public int HowMuchKarma(){
        return Karma;
    }
    void Start()
    {
        
    }
    
    void exorcismTime(){
        //Possible fails: die to fire, mom dies, mom kills you when she gets out
        //Have to do all exorcism prayers in a certain amount of time
        //every single passage of time something has a chance of happening
        //priority: mother, older sister, younger sister
    }

    // Update is called once per frame
    void Update()
    {
        if(criteriaLeft == 0){
            exorcismTime();
        }
    }
}
