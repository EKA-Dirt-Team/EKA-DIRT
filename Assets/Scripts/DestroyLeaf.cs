using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyLeaf : MonoBehaviour
{
    private float leaves = 0;
    public TextMeshProUGUI textLeaves;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pickup"))
        {
            Debug.Log("boop");
            leaves++;
            textLeaves.text = leaves.ToString();
            Destroy(collision.gameObject);
        }
    }
}