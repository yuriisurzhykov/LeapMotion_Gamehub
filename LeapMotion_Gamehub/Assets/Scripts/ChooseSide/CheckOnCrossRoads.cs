using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOnCrossRoads : MonoBehaviour
{
    private int quantityCars;
    // [SerializeField] private List<CheckSide> allTriggers;
    private List<GameObject> bots = new List<GameObject>();

    // [SerializeField] private bool isCrossRoads = true;
    [SerializeField] private bool isNotCrossRoads = false;

    public int QuantityCars
    {
        get { return bots.Count; }
     //   set { quantityCars = value; }
    }

    public List<GameObject> BotsList
    {
        get { return bots; }
        set { bots = value; }
    }

    private void Start()
    {
        quantityCars = 0;
    }

    private void Update()
    {
      
    }

   

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Bot") {
            //   quantityCars++;

            var bot = col.gameObject.GetComponent<BotsController>();
            if (!isNotCrossRoads)
                bot.IsTouchCrossRoads = true;
            else bot.IsTouchCrossRoads = false;
            bot.CrossRoadsInfo = gameObject.GetComponent<CheckOnCrossRoads>();
            bots.Add(col.gameObject);

        }
    }


    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Bot")
        {
            //   quantityCars--;
            var bot = col.gameObject.GetComponent<BotsController>();
            bot.IsTouchCrossRoads = false;
            bot.CrossRoadsInfo = null;
            bots.Remove(col.gameObject);
        }
    }
}
