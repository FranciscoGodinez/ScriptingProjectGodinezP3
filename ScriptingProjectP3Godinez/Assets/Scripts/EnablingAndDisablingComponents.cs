using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablingAndDisablingComponents : MonoBehaviour
{
    // Start is called before the first frame update
    private Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
