using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBackground : MonoBehaviour
{
    
    public GameObject Background;
    public Material BackgroundMaterial;
    // Start is called before the first frame update
    void Start()
    {
        Background.SetActive(true);
        Background.GetComponent<SpriteRenderer>().material = BackgroundMaterial;
    }
}
