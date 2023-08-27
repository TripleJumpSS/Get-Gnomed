using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shueyoobfailsafe : MonoBehaviour
{
    public GameObject OOBsaver;
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "OOB")
        {
            this.transform.position = OOBsaver.transform.position;
        }
    }
}
