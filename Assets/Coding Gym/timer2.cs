using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer2 : MonoBehaviour
{
     Slider slider;
     float t;
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        slider.value = t;
    }
}
