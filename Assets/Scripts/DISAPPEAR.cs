using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DISAPPEAR : MonoBehaviour
{
   public GameObject matchstick;
   public void play()
   {
     matchstick.SetActive(false);
   }
}
