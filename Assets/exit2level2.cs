using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit2level2 : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collide)
    {
        if (collide.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("dads");
        }
    }
}
