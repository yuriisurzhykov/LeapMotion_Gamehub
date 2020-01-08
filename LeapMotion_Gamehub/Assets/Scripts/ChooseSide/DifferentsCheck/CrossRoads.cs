using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossRoads : CheckSide
{
    [SerializeField] private CheckSide rightHindrance;
    public CheckSide RightHindrance
    {
        get { return rightHindrance; }
        set { rightHindrance = value; }
    }

   
  
    void OnTriggerEnter(Collider other)
    {
        TriggerEnter(other, ChooseRoad());
    }

     void OnTriggerStay(Collider other)
    {
        TriggerStay(other,rightHindrance);
    }

     void OnTriggerExit(Collider other)
    {
        TriggerExit(other);
    }

 
}
