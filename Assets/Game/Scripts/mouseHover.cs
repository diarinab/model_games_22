using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseHover : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        RaycastHit hit;

        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 1000f) && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(new Vector3(0, 2f, 0), ForceMode.Impulse);
        }
    }
}