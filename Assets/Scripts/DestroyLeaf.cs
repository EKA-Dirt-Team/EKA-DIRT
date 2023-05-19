using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyLeaf : MonoBehaviour
{
    public TextMeshProUGUI textLeaves;
    public GameObject player;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pickup"))
        {
            Debug.Log("Leaf Collected");
            textLeaves.GetComponent<Score>().AddLeaf();
            Destroy(collision.gameObject);
        }
    }
}