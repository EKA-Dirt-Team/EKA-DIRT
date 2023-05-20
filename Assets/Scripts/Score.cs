using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Pulbic Score Variables
    public float maxleaves = 0;
    public string regularText = "{0}/{1}";
    public string winText = "You Win!";
    public GameObject TextUIText;
    public GameObject MenuUIText;

    // Private Score Variables
    TextMeshProUGUI textLeavesGame;
    TextMeshProUGUI textLeavesMenu;
    private float leaves = 0;

    // Start is called before the first frame update
    public void AddLeaf()
    {
        leaves++;
    }

    private void Start()
    {
        textLeavesGame = TextUIText.GetComponent<TextMeshProUGUI>();
        textLeavesMenu = MenuUIText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (leaves >= maxleaves)
        {
            textLeavesGame.text = winText;
            textLeavesMenu.text = winText;
        }
        else
        {
            var textString = string.Format(regularText, leaves, maxleaves);
            textLeavesGame.text = textString;
            textLeavesMenu.text = textString;
        }

    }

    public bool canWin()
    {
        if (leaves >= maxleaves) return true;
        else return false;
    }
}