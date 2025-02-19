using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smokefloat : MonoBehaviour
{
    public float up;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Creates a vector2 to store the current spawners position 
        Vector2 smokepos;
        smokepos = transform.position;
        //tells the smoke object to go up every loop of update so the smoke rises to the top of the screen
        smokepos.y += up * Time.deltaTime;

        //makes the transformation = to smokepos so only the y axis of the smoke is changed 
        transform.position = smokepos; 
    }
}
