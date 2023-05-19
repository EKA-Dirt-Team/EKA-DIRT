using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBackground : MonoBehaviour
{
    
    public GameObject Background;
    // Start is called before the first frame update
    void Start()
    {
        Background.SetActive(true);
    }
}
