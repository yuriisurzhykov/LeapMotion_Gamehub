using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelSystem : MonoBehaviour {
    private BotsController bot;
    private float timer=8f;
   


    void OnTriggerEnter(Collider col){
        if (col.tag == "Bot") {
            bot = col.gameObject.GetComponent<BotsController>();
            bot.Speed = 0f;

        }
    } 
    
    void OnTriggerStay(Collider col){
        if (col.tag == "Bot") {
            bot = col.gameObject.GetComponent<BotsController>();
            StartTimer();

        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Bot")
        {
            bot = null;
            SetTimer();
        }
    }

    void StartTimer() {  
        if (bot != null && timer >= 0)
        {
            timer -= Time.deltaTime*ClickBoost.boost;
        }
        else if(!bot.IsTouchNextCar && timer <=0) {
            bot.Speed = 0.3f;         
        } 
    }

    void SetTimer() {
        timer = 8f;
    }

   


    // Start is called before the first frame update
    void Start()
    {
        SetTimer();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
