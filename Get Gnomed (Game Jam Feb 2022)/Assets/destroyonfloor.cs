using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyonfloor : MonoBehaviour
{
    public GameObject Goal;
    public GameObject thisthing;
    public string thethingisdone;
public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "thefloor")
        {
            Goal.SendMessage(thethingisdone);
            thisthing.SetActive(false);
        }
}
}
