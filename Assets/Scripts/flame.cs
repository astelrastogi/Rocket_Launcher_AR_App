using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flame : MonoBehaviour
{
    public GameObject fire,rocketfire,fireworks;
    public GameObject rocket1,rocket2,rocket3,rocket4;
    public Transform rocket; 
    Vector3 temp;
    bool f=false;

    void OnMouseDown(){
        fire.SetActive(true);
        rocketfire.SetActive(true);
        f=true;
    }
    void Start(){
        temp=rocket.localPosition;
    }
    void Update(){
        if (f==true&& temp.y<=25f){
            Invoke("fly",3.0f);
        }
        if (temp.y> 25f){
            fireworks.SetActive(true);
            Invoke("stop",3.0f);
        }
          
        }
    void fly(){
        temp.y +=5.0f;
        rocket.localPosition =temp;
        }
    void stop(){
            Destroy(rocket1);
            Destroy(rocket2);
            Destroy(rocket3);
            Destroy(rocket4);
    }
}
