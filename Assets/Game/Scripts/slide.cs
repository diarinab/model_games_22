using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide : MonoBehaviour
{
    float dir_x = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, dir_x));
    }
    private void OnTriggerEnter(Collider other)
    {
        dir_x += -1;
    }
}
