using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOtherB :  SpawnBots
{
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        countB = settingBots.OtherB;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnBot(BotsSystem.botsO);
    }
}
