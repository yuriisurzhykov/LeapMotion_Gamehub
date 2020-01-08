using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class OpenHandMenu : MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    // Update is called once per frame
    void Update()
    {
        Quaternion quaternion = transform.localRotation;
        if ((quaternion.x < 0.5f && quaternion.x > 0.08f) || (quaternion.x > -0.5f && quaternion.x < -0.09f))
        {
            menu.SetActive(true);
        }
        else
        {
            menu.SetActive(false);
        }
    }
}
