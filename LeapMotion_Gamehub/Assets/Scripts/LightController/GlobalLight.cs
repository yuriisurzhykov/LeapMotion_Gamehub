using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalLight : MonoBehaviour
{

    [SerializeField] private float Speed;
    [SerializeField] private bool changeDay;
    // Use this for initialization

    public bool ChangeDay
    {
        get { return changeDay; }
        set { changeDay = value; }
    }

    void FixedUpdate()
    {
        if (changeDay)
            gameObject.transform.Rotate(Vector3.left * Speed * Time.deltaTime);
        else
            gameObject.transform.rotation = Quaternion.Euler(90, 0, 0);


    }

}