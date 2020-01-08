using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotater : MonoBehaviour
{
    public float speedRot = 1f;


    int counter = 1;

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftShift))
            RotateW(1);
        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftShift))
            RotateW(-1);
        else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.LeftShift))
            RotateZ(1);
        else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftShift))
            RotateZ(-1);
        else if (Input.GetKey(KeyCode.UpArrow))
            RotateX(1);
        else if (Input.GetKey(KeyCode.DownArrow))
            RotateX(-1);
        else if (Input.GetKey(KeyCode.LeftArrow))
            RotateY(1);
        else if (Input.GetKey(KeyCode.RightArrow))
            RotateY(-1);
    }

    [System.Obsolete]
    private void RotateX(int diraction)
    {
        transform.RotateAroundLocal(Vector3.right, speedRot * diraction);
    }

    [System.Obsolete]
    private void RotateY(int diraction)
    {
        transform.RotateAroundLocal(Vector3.up, speedRot * diraction);
    }

    [System.Obsolete]
    private void RotateZ(int diraction)
    {
        transform.RotateAroundLocal(Vector3.forward, speedRot * diraction);
    }

    [System.Obsolete]
    private void RotateW(int diraction)
    {
        //transform.Rotate();
    }
}
