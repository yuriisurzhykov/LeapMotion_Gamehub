using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOnRoads : MonoBehaviour
{

    private BotsController bot;
    private BotsController botFromPlace;
    private int quantityCars;
    private List<GameObject> bots = new List<GameObject>();
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

    public BotsController BotFromPlace
    {
        get { return botFromPlace; }
        set {  botFromPlace=value; }
    }
    
    void OnTriggerEnter(Collider col)
    {
        if (botFromPlace != null)
        {
            if (col.tag == "Bot" && col.gameObject != botFromPlace.gameObject)
            {
                bot = col.gameObject.GetComponent<BotsController>();
                bots.Add(col.gameObject);

            }
        }
    } 
    
    void OnTriggerExit(Collider col)
    {
        if (botFromPlace != null)
        {
            if (col.tag == "Bot" && col.gameObject != botFromPlace.gameObject)
            {
                bot = col.gameObject.GetComponent<BotsController>();
                bots.Remove(col.gameObject);

            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
