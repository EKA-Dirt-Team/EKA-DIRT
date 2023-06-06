using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winorlose : MonoBehaviour
{
       public Score score;
       public void OnCollisionEnter2D(Collision2D collide)
       {
           if (collide.gameObject.tag == "Player")
           {
               if (GameObject.Find("Counter").GetComponent<Score>().canWin() == true)
               {
                   //Debug.Log ("you win");
                   SceneManager.LoadScene("win screen");
               }
               //else Debug.Log ("you lose");
               else SceneManager.LoadScene("lose screen");
           }
       }
   
   
}
