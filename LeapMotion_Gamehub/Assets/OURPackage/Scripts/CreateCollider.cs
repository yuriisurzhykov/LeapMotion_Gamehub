using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;
using System;

public class CreateCollider : MonoBehaviour
{
    [SerializeField] private float sphereRadius;

    // Start is called before the first frame update
    void Start()
    {
        CreateVirtualColliders();
    }

    private void CreateVirtualColliders()
    {
        foreach(var point in gameObject.GetComponentsInChildren<Transform>())
        {
            if (point.name == "Canvas" ||
                point.name == "RedBrick" ||
                point.name == "GreenBrick" ||
                point.name == "ButtonBackdrop")
                continue;
            var col = point.gameObject.AddComponent<SphereCollider>();
            col.isTrigger = false;
            col.radius = sphereRadius;
        }
    }
}