using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Timed : MonoBehaviour
{
    Slider slidertime;
    public float maxmin; 
    // Start is called before the first frame update
    void Start()
    {
        slidertime = GetComponent<Slider>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //makes the timer go up by Time.deltaTime
        maxmin += Time.deltaTime;
        //Lets the timer loop around using the modules tool 
        slidertime.value = maxmin % slidertime.maxValue; 
    }
}
