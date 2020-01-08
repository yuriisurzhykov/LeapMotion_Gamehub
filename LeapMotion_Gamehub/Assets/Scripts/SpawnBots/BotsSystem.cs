using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotsSystem : MonoBehaviour
{

    public static List<GameObject> botsT = new List<GameObject>();
    public static List<GameObject> botsO = new List<GameObject>();

    // Start is called before the first frame update

    int maxB, otherB, taxiB;
    public int OtherB
    {
        get { return otherB; }
    }
    public int TaxiB
    {
        get { return taxiB; }
    }

    void Awake()
    {
        maxB = (int)(GameObject.FindGameObjectsWithTag("Road").Length/8.28f);
        otherB =(int)(maxB * 0.3f);
        taxiB = maxB - otherB;
      
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
