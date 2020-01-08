using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOnSpawnPoint : MonoBehaviour
{
    private bool checkBot;


    public bool CheckBot {
        get { return checkBot; }
        set { checkBot = value; }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Bot")
            checkBot = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Bot")
            checkBot = false;
    }
}
