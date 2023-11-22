using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class PlayerController : MonoBehaviour
{

    public float CurrentTime = 5;
    public float MaxTime = 5;
    public text FuelText;
    public Image FuelImage;
    // Start is called before the first frame update
    void Update(){
        UpdateUI();

    }

    public void UpdateUI(){

        FuelImage.fillAmount = CurrentTime / MaxTime;
        FuelText.text = "Fuel: " + (CurrentTime / MaxTime).ToString();

    }//ui for fuel
}
