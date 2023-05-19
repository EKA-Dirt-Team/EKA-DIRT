
using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Pulbic Score Variables
    public float maxleaves = 0;
    public string regularText = "{0}/{1}";
    public string winText = "You Win!";
    
    // Private Score Variables
    TextMeshProUGUI textLeaves;
    private float leaves = 0;
    
    // Start is called before the first frame update
    public void AddLeaf()
    {
        leaves++;
    }

    private void Start()
    {
        textLeaves = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (leaves >= maxleaves)
        {
            textLeaves.text = winText;
        }
        else
        {
            var textString = String.Format(regularText, leaves, maxleaves);
            textLeaves.text = textString;
        }


        
    }
}
