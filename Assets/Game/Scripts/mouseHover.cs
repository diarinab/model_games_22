using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseHover : MonoBehaviour
{
    public Rigidbody[] bullets;
    void Start()
    {

    }

    void Update()
    {
        RaycastHit hit;

        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 1000f) && hit.transform.gameObject.tag == "trigger")
        {
            foreach(Rigidbody bullet in bullets)
            {
                bullet.AddForce(Vector3.forward*-100f);
            }
        }
    }
}