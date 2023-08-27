using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShueyEatStuff : MonoBehaviour
{
    public GameObject eatprompt;
    public bool caneat;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "food")
        {
            eatprompt.SetActive(true);
            caneat = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "food")
        {
            eatprompt.SetActive(false);
            caneat = false;
        }
    }

    void Update()
    {
        if(caneat == true && Input.GetMouseButton(0))
        {
            eatprompt.SetActive(false);
            this.SendMessage("AteFood");
            caneat = false;
        }
    }
}
