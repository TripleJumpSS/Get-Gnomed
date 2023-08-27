using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shueydisappearwheneaten : MonoBehaviour
{
    public bool caneat;
    public GameObject thisthing;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            caneat = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            caneat = false;
        }
    }

    void Update()
    {
        if(caneat == true && Input.GetMouseButton(0))
        {
            thisthing.SetActive(false);
        }
    }
}
