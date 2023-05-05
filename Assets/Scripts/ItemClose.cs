using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ItemClose : MonoBehaviour
{
    public GameObject itemScreen;
    public GameObject priorScreen;
    public GameObject priorButton;
    public Button closeScreenButton;
    // Start is called before the first frame update
    public void closeScreen(){
        priorScreen.SetActive(true);
        priorButton.SetActive(true);
        itemScreen.SetActive(false);
    }
    void Start()
    {
        closeScreenButton.onClick.AddListener(closeScreen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
