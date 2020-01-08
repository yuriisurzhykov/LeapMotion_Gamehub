using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossRoadsMain : CheckSide
{
    void OnTriggerEnter(Collider other)
    {
        TriggerEnter(other, ChooseRoad());
    }

     void OnTriggerStay(Collider other)
    {
        TriggerStay(other);
    }

     void OnTriggerExit(Collider other)
    {
        TriggerExit(other);
    }

  
}
