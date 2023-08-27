using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha0))
        {scene0();}
        if(Input.GetKey(KeyCode.Alpha1))
        {scene1();}
        if(Input.GetKey(KeyCode.Alpha2))
        {scene2();}
        if(Input.GetKey(KeyCode.Alpha3))
        {gameover();}
    }
    
    public void scene0()
    {
        SceneManager.LoadScene(0);
    }
    public void scene1()
    {
        SceneManager.LoadScene(1);
    }

    public void scene2()
    {
        SceneManager.LoadScene(2);
    }
    public void gameover()
    {
        SceneManager.LoadScene(3);
    }
    public void SUCCESS()
    {
        SceneManager.LoadScene(4);
    }

}

