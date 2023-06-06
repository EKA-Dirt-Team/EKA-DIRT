using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winorlose : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collide)
       {
           if (collide.gameObject.tag == "Player")
           {
               Debug.Log ("you win");

               //if (Score.canWin() = true)
               // {
               //     SceneManager.LoadScene("win screen");
               //}
               //else SceneManager.LoadScene("lose screen");
           }
       }
   
   
}
