using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveTrain : MonoBehaviour
{
    public float pos; 
    // Start is called before the first frame update
    void Start()
    {
        
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

        
    }

    //Creates a public void go for our slider to reference 
    public void Go(float s)
    {
        //Updates the position to the value of the slider 
        pos = s;
        
    }
}
