using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI; 

public class MoveTrain : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI count; 
    public float pos;
    public float val; 
    // Start is called before the first frame update
    void Start()
    {
        //Makes a starting value for the slider so the train starts at +5 on the x-axis
        slider.value = 5.0f;
        //Makes text equal to said starting position 
        count.text = val.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        //Creates a vector2 to store a new x value that can later be used to update our objects position 
        Vector2 mouseX;
        //Stores the objects position before updating with a new x value
        mouseX = transform.position;
        mouseX.x = pos;
       
        //Returns the same y value as was stored but now with an updated x so our object can match the position of the slider. 
        transform.position = mouseX;
        //Makes the value equal to the sliders value and then updates the text to match
        val = slider.value; 
        count.text = val.ToString();

    }

    //Creates a public void go for our slider to reference 
    public void Go(float s)
    {
        //Updates the position to the value of the slider 
        pos = s;
        
    }
}
