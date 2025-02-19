using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seagulmove : MonoBehaviour
{
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        speed = 5; 
    }

    // Update is called once per frame
    void Update()
    {
        //Creates a vector to store the position of the seaguls at the start 
        Vector2 seagulpos;
        seagulpos = transform.position;
        //Moves the seaguls by an adjustable speed variable
        seagulpos.x += speed * Time.deltaTime; 

        //If the seaguls get too far off screen sets them back to where they should be 
        if(seagulpos.x > 20)
        {
            seagulpos.x = -25; 
        }
        //Updates the seaguls position 
        transform.position = seagulpos;
    }
}
