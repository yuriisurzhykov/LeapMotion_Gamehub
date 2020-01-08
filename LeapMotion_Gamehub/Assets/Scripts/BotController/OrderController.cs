using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderController : MonoBehaviour
{
    private float timerWait, timerRealization;
    private float minTWait = 10, maxTWait = 20;
    private float boostWait;
    private int addM;

    private MoneyController wallet;

    private bool orderStatus;

    public bool OrderStatus
    {
        get { return orderStatus; }
        set { orderStatus = value; }
    }


    public void SetTimer() {
        orderStatus = false;
        timerWait = Random.Range(minTWait, maxTWait);
        timerRealization = Random.Range(minTWait, maxTWait );
        addM = (int)timerRealization;
        wallet = GameObject.Find("Wallet").GetComponent<MoneyController>();
    }

    public void RealizationOrder(bool onCrossCroads, float speed) 
    {
        timerWait -= Time.deltaTime*ClickBoost.boost;
        if (!onCrossCroads && speed != 0 && timerWait<=0) {
            timerRealization -= Time.deltaTime*ClickBoost.boost;
            orderStatus = true;
        }

        if (timerRealization <= 0)
        {
            wallet.Money += addM;

            SetTimer();
           // Debug.Log("Successful order");
        }
    }




}
