using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BustedScreen : MonoBehaviour
{

    public GameObject canvas;

    public float time; 

    void Awake()
    {
        StartCoroutine(Wait());
    }
    
    void Update()
    {
     // StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(time);
                
        canvas.SetActive(true);
    }
}
