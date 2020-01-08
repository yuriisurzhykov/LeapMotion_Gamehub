using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiCarController : BotsController
{
    private OrderController order;
    [SerializeField] private GameObject lightChecker;
    public OrderController Order
    {
        get { return order; }
        set { order = value; }
    }

    private void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        order = new OrderController();
        order.SetTimer();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    order.RealizationOrder(IsTouchCrossRoads, Speed);
    //    GoIf(Speed, IsTouchNextCar);
    //    DeleteIfCrossRoads(Speed, IsTouchCrossRoads);
    //    gameObject.transform.Translate(new Vector3(0, 0, Speed));

    //    CheckRot();
    //}

    private void FixedUpdate()
    {
        if (!order.OrderStatus)
            lightChecker.SetActive(true);
        else lightChecker.SetActive(false);
    }
    private void Update()
    {
        
        order.RealizationOrder(IsTouchCrossRoads, Speed);
      
        base.Update();
        DeleteIfCrossRoads(speed, IsTouchCrossRoads, BotsSystem.botsT);
    }

}
