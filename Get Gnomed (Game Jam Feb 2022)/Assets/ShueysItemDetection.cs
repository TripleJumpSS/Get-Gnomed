using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShueysItemDetection : MonoBehaviour
{
    public bool TVRemoteGet;
    public bool RoundCup1Get;
    public bool RoundCup2Get;
    public bool RoundCup3Get;
    public bool RoundCup4Get;
    public bool RoundCup5Get;
    public bool Plate1Get;
    public bool Plate2Get;
    public bool Plate3Get;
    public bool Plate4Get;
    public bool VaseGet;
    public bool CoffeeCupGet;
    public int points;
    [SerializeField] Text pointtext;
    public GameObject SceneMan;
    public string nameofscene;
    
    void Update()
    {
        pointtext.text = points.ToString("0");

        if(TVRemoteGet == true && RoundCup1Get == true && RoundCup2Get == true  && RoundCup3Get == true  && RoundCup4Get == true  && RoundCup5Get == true 
         && Plate1Get == true  && Plate2Get == true  && Plate3Get == true  && Plate4Get == true && VaseGet == true && CoffeeCupGet == true)
         {SceneMan.SendMessage(nameofscene);}
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plate 1" && Plate1Get == false)
        {
            Plate1Get = true;
            points += 100;
        }
        if (collision.gameObject.name == "Plate 2" && Plate2Get == false)
        {
            Plate2Get = true;
            points += 100;
        }
        if (collision.gameObject.name == "Plate 3" && Plate3Get == false)
        {
            Plate3Get = true;
            points += 100;
        }
        if (collision.gameObject.name == "Plate 4" && Plate4Get == false)
        {
            Plate4Get = true;
            points += 100;
        }
    }

    public void Remote()
    {
        TVRemoteGet = true;
        points += 150;
    }

    public void Vase()
    {
        VaseGet = true;
        points += 500;
    }

    public void RoundCup1()
    {
        RoundCup1Get = true;
        points += 100;
    }
    public void RoundCup2()
    {
        RoundCup2Get = true;
        points += 100;
    }
    public void RoundCup3()
    {
        RoundCup3Get = true;
        points += 100;
    }
    public void RoundCup4()
    {
        RoundCup4Get = true;
        points += 100;
    }
    public void RoundCup5()
    {
        RoundCup5Get = true;
        points += 100;
    }
    public void CoffeeCup()
    {
        CoffeeCupGet = true;
        points += 150;
    }
}
