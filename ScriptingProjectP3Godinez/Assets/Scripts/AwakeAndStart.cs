using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    void Awake ()
    {
        Debug.Log("Awake called.");
    }

    private void Start()
    {
        Debug.Log("start called.");

    }
}
