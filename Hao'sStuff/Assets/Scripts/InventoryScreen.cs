using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InventoryScreen : MonoBehaviour
{
    public GameObject inventoryCanvas;
    public GameObject secondInventoryCanvas;
    public GameObject mostlyEverything;
    public Button inventoryButton;
    public SpriteRenderer back;
    public Sprite ogBackground;
    public Sprite newBackground;
    // Start is called before the first frame update
    public void changeBG(){
        if(back.sprite == ogBackground){
            back.sprite = newBackground;
            inventoryCanvas.SetActive(true);
            mostlyEverything.SetActive(false);
        }else{
            back.sprite = ogBackground;
            inventoryCanvas.SetActive(false);
            mostlyEverything.SetActive(true);
        }
    }

    void Start()
    {
        inventoryButton.onClick.AddListener(changeBG);
        inventoryCanvas.SetActive(false);
        secondInventoryCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
