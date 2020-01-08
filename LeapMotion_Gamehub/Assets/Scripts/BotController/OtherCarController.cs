using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCarController : BotsController
{
    // Start is called before the first frame update
    private void Awake()
    {
        base.Awake();
    }

    // Update is called once per frame
    void Update()
    {

        base.Update();
        DeleteIfCrossRoads(speed, IsTouchCrossRoads, BotsSystem.botsO);
    }
}
