using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
    public Transform playerLocation;
    public Light lightDot;
    
    void Update()
    {
        Instantiate(lightDot, playerLocation);
    }
}
