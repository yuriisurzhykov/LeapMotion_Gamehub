using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBricks : MonoBehaviour
{
    [SerializeField]
    GameObject redCube;
    [SerializeField]
    GameObject greenCube;

    public void SpawnRedBrick()
    {
        Instantiate(redCube, 
                    new Vector3(transform.position.x + Random.Range(-0.02f, 0.02f),
                                transform.position.y + Random.Range(-0.02f, 0.02f),
                                transform.position.z + Random.Range(-0.02f, 0.02f)), 
                    Quaternion.identity);
    }
    public void SpawnGreenBrick()
    {
        Instantiate(greenCube, 
                    new Vector3(transform.position.x + Random.Range(-0.02f, 0.02f),
                                transform.position.y + Random.Range(-0.02f, 0.02f),
                                transform.position.z + Random.Range(-0.02f, 0.02f)), 
                    Quaternion.identity);
    }

    public void MoveSwitcher()
    {
        if (FPSController.instance.canMoving)
            FPSController.instance.canMoving = false;
        else
            FPSController.instance.canMoving = true;
    }
}
