using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBasicScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Destroy(gameObject);
        }
    }
}
