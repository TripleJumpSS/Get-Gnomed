using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spacetoretry : MonoBehaviour
{
    public GameObject SceneMan;
    public string nameofscene;
    void Update()
    {
        if(Input.anyKeyDown)
        {SceneMan.SendMessage(nameofscene);}
    }
}
