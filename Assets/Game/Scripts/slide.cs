using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide : MonoBehaviour
{
    float dir_y = 1;

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, dir_y, 0));
    }
    private void OnTriggerEnter(Collider other)
    {
        dir_y *= -1;
    }
}
