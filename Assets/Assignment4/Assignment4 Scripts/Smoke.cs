using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    public GameObject smokeup;
    public Transform train; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void Go()
    {
        //Instantiates the smoke object as newsmoke so the original is not deleted 
        GameObject newsmoke = Instantiate(smokeup, train.position, train.rotation);
        //Destroys the new object after 2 seconds as the smoke is off screen by this time
        Destroy(newsmoke, 2);
    }
}
