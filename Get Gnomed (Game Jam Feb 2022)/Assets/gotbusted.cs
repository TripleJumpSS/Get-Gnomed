using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotbusted : MonoBehaviour
{
    public GameObject SceneMan;
    public string nameofscene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneMan.SendMessage(nameofscene);
        }
    }
}
