using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTuchTrigger : MonoBehaviour
{
    private BotsController thisBot;
    private BotsController bot;
    private void Start()
    {
        thisBot=  transform.parent.gameObject.GetComponent<BotsController>();
    }



    
    void OnTriggerEnter(Collider col)
    {

        if (col.tag=="Bot")
        {
            bot = col.gameObject.GetComponent<BotsController>();

            thisBot.IsTouchNextCar = true;
            thisBot.Speed = 0;
           

        }
    }

    void OnTriggerExit(Collider col)
    {

        if (col.tag == "Bot")
        {
            bot = col.gameObject.GetComponent<BotsController>();
            thisBot.IsTouchNextCar = false;
            thisBot.Speed = 0.3f;


        }
    }


    // Update is called once per frame
    void Update()
    {
        if (thisBot.IsTouchNextCar && bot == null) {
            thisBot.IsTouchNextCar = false;
            thisBot.Speed = 0.3f;
        } 
    }
}
