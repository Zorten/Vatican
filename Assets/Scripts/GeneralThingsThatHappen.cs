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

    // Update is called once per frame
    void Update()
    {
        
    }
}
