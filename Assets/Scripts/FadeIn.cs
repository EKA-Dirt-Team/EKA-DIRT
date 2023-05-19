using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    
    public GameObject BlackScreen;
    public Image BlackScreenImage;
    
    // Start is called before the first frame update
    void Start()
    {
        BlackScreenImage = BlackScreen.GetComponent<Image>();
        StartCoroutine(FadeInFun());  
    }
    
    private IEnumerator FadeInFun()
    {
        BlackScreen.SetActive(true);
        for (float t = 0; t <= 4; t += Time.deltaTime)
        {
            var newColor = BlackScreenImage.color;
            newColor.a = Mathf.Lerp(1, 0, t);
            BlackScreenImage.color = newColor;
            yield return null;
        }
        
        BlackScreen.SetActive(false);
    }
    
    
}
