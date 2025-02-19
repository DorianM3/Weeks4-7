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
        maxmin += Time.deltaTime;
        slidertime.value = maxmin % slidertime.maxValue; 
    }
}
