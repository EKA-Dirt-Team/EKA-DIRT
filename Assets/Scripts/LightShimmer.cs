using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightShimmer : MonoBehaviour
{
    
    public GameObject Player;
    public bool PulsingIntensity = false;
    public float IntensityMin = 0.5f;
    public float IntensityMax = 1.5f;
    public float IntenistyTime = 1f;
    public bool PulsingRadius = false;
    public float RadiusMin = 10f;
    public float RadiusMax = 15f;
    public float RadiusTime = 1f;
    public float transitionSpeed = 1f;
    private Light2D playerlight;
    
    // Start is called before the first frame update
    void Start()
    {
        playerlight = Player.GetComponent<Light2D>();
    }
    
    void FixedUpdate()
    {
        if (PulsingIntensity)
        {
            var newIntensity = Mathf.Lerp(IntensityMin, IntensityMax, Mathf.PingPong(Time.time, IntenistyTime));
            playerlight.intensity = newIntensity;
        }
        
        if (PulsingRadius)
        {
            var t = Mathf.PingPong(Time.time * transitionSpeed, RadiusTime);
            var radius = Mathf.Lerp(RadiusMin, RadiusMax, t);
            playerlight.pointLightOuterRadius = radius;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
