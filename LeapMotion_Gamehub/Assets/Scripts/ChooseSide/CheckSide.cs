using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSide : MonoBehaviour
{


    [SerializeField] private CheckOnCrossRoads roadsInfo;
    [SerializeField] private bool isCheckPlace;
    private int quantityCars=0;
    public float distL = 18.5f + 3.06f;
    public float distR = 11 + 3.06f;

    public int min = 0, max = 2;


    //   [SerializeField] private CheckSide rightHindranceBuf;
    private BotsController bot;

    private void Start()
    {
        if (isCheckPlace)
            quantityCars = 4;
    }

    public BotsController Bot
    {
        get { return bot; }
        set { bot = value; }
    }

    public void TriggerEnter(Collider col, int side)
    {

        if (col.tag == "Bot" )
        {         

                 bot = col.gameObject.GetComponent<BotsController>();
            //if (checkOnRoads != null) 
            //{
            //    checkOnRoads.BotFromPlace = bot;
            //}
                 bot.RndSide = side;
                 bot.RandomWay(distR, distL);
        }
    }

    public void TriggerStay(Collider col)
    {


        if (col.tag == "Bot")
        {
            bot = col.gameObject.GetComponent<BotsController>();

            if (!isCheckPlace)
            {
                if (!bot.IsTouchNextCar && roadsInfo.QuantityCars <= 0)
                    bot.Speed = 0.3f;
                else bot.Speed = 0;
            }

           
            //if (rightHindrance == null && leftHindrance == null && crossRoadsInfo == null && checkOnRoads != null) {
            //    if (!bot.IsTouchNextCar && checkOnRoads.QuantityCars == 0)
            //        bot.Speed = 0.3f;
            //    else bot.Speed = 0;
            //}
            //else if ( rightHindrance == null && leftHindrance == null && crossRoadsInfo == null) 
            //{ 
            //    bot.Speed = 0.3f;
            //}
         
            //else if (rightHindrance != null && leftHindrance != null)
            //{
            //    if (crossRoadsInfo.QuantityCars > 0 || rightHindrance.bot != null || leftHindrance.bot != null)
            //        bot.Speed = 0;
            //    else if (!bot.IsTouchNextCar)
            //        bot.Speed = 0.3f;
            //}
            //else if (rightHindrance != null && leftHindrance == null)
            //{
            //    if (crossRoadsInfo.QuantityCars > 0 || rightHindrance.bot != null)
            //        bot.Speed = 0;
            //    else if (!bot.IsTouchNextCar)
            //        bot.Speed = 0.3f;
            //}






        }
    }

    public void TriggerStay(Collider col, CheckSide rightHid) 
    {
        if (col.tag == "Bot")
        {
            bot = col.gameObject.GetComponent<BotsController>();
            if (roadsInfo.QuantityCars > 0 || rightHid.Bot != null)
                bot.Speed = 0;
            else if (!bot.IsTouchNextCar)
                bot.Speed = 0.3f;
        }
    }


    public void TriggerExit(Collider col)
    {
        if (col.tag == "Bot")
        {

            bot = col.gameObject.GetComponent<BotsController>();
           
        //    rightHindrance = rightHindranceBuf;
            bot = null;
        }

        
    }

    public int ChooseRoad() {
        int chooseR = 0;
        chooseR = Random.Range(min, max + 1);
        if (isCheckPlace && roadsInfo.QuantityCars==quantityCars)
            chooseR = 0;
        return chooseR;
    }
   



    //private int ChooseRoad()
    //{
    //    int chooseR = 0;
    //    switch (gameObject.name)
    //    {
    //        case "СrossRoadsTrigger":
    //            chooseR = Random.Range(1, 4);
    //            break;
    //        case "OnlyLeftRoadTrigger":
    //            chooseR = 1;
    //            break;
    //        case "OnlyRightRoadTrigger":
    //            chooseR = 3;
    //            break;
    //        case "TCrossRoadsTrigger":
    //            chooseR = Random.Range(1, 3);
    //            if (chooseR == 2)
    //                chooseR = 3;
    //            break;
    //        case "LeftTCrossRoadsTrigger":
    //            chooseR = Random.Range(1, 3);         
    //            break;
    //        case "RightTCrossRoadsTrigger":
    //            chooseR = Random.Range(2, 4);
              
    //            break;
    //        case "ExitFromRepair":
    //            chooseR = Random.Range(4, 6);
    //            break;
    //        case "CheckOnTurnFuel":
    //            if (!bot.Order.OrderStatus)
    //            {
    //                chooseR = Random.Range(3, 6);
    //                Debug.Log(chooseR);
    //                if (chooseR > 3)
    //                    chooseR = 0;
              
    //                Debug.Log(chooseR);
    //            }
    //            break; 
    //        case "CheckOnTurnFuelLeft":             
    //                chooseR = 4;

    //            Debug.Log(chooseR);
    //            break;
    //        case "ExitFromFuel":
    //            chooseR = Random.Range(4, 6);
    //            break;
    //    }
      
    //    return chooseR;
   // }


  

}
