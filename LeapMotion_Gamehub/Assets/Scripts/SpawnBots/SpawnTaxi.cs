using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTaxi : SpawnBots
{
     // Start is called before the first frame update
    void Start()
    {
        base.Start();
        countB = settingBots.TaxiB;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnBot(BotsSystem.botsT);
    }
}
