using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shueyfalldamage : MonoBehaviour
{
    public bool ontheground;
    public bool canstartfalling;
    public Vector3 FallStartingPoint;
    public Vector3 FallEndingPoint;
    public Vector3 FallDifference;
    public float FallDifferenceHPDown;
    public float HP = 10;
    [SerializeField] Text PreText;
    [SerializeField] Text PostText;
    [SerializeField] Text TheDifference;
    [SerializeField] Text HPText;
    public GameObject Player;
    public GameObject GameOverScreen;

    // Update is called once per frame
    void Update()
    {
        if(HP > 10)
        {HP = 10;}

        if(HP < 0)
        {HP = 0;}
        if(HP == 0)
        {Player.GetComponent<CharacterController>().enabled = false; GameOverScreen.SetActive(true); Player.GetComponent<spacetoretry>().enabled = true;}

        if(Input.GetKey(KeyCode.Q))
        {HP += 1;}

        ontheground = this.GetComponent<PlayerMovement>().grounded;
        HPText.text = HP.ToString("0");

        if(ontheground == false && canstartfalling == true)
        {
            FallStartingPoint = this.transform.position;
            canstartfalling = false;
            PreText.text = FallStartingPoint.y.ToString("0");
        }

        if(ontheground == true && canstartfalling == false)
        {
            FallEndingPoint = this.transform.position;
            canstartfalling = true;
            PostText.text = FallEndingPoint.y.ToString("0");
            FallDifference.y = FallStartingPoint.y -= FallEndingPoint.y;
            TheDifference.text = FallDifference.y.ToString("0");
            DecreaseHP();
        }
        
        
        
    }

    void DecreaseHP()
    {
        HP = Mathf.Round(HP * 10.0f) * 0.1f;
        FallDifferenceHPDown = Mathf.Round(FallDifference.y * 1f) * 1f;
        
        if(FallDifferenceHPDown >= 0) 
        {HP -= FallDifferenceHPDown;}
    }

    void AteFood()
    {
        HP += 2;
    }
}
