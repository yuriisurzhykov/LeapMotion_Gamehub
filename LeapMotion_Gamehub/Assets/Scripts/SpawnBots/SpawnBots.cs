using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBots : MonoBehaviour
{

  
    [SerializeField]private List<GameObject> bots =new List<GameObject>();
    [SerializeField]private GameObject spawnPoint;
    private CheckOnSpawnPoint checkSP;
    protected int countB;
    protected BotsSystem settingBots; //все боты


    public void Start()
    {
        checkSP = spawnPoint.GetComponent<CheckOnSpawnPoint>();
        settingBots = GameObject.FindObjectOfType<BotsSystem>();
    }
    


    public void SpawnBot(List<GameObject> bots)
    {

        if (!checkSP.CheckBot && bots.Count < countB)
        {
            var bot = this.bots[Random.Range(0, this.bots.Count)];
            GameObject b = Instantiate(bot, spawnPoint.transform.position, Quaternion.Euler(0, -transform.eulerAngles.y, 0));
            bots.Add(b);
        }
    }
}
