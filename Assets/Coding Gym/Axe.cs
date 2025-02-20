using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    bool isTriggered;
    public float s; 
    // Start is called before the first frame update
    void Start()
    {
        s = -50;
        isTriggered = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activated()
    {
        isTriggered = true;
        transform.Rotate(0, 0, s * Time.deltaTime); 
    }
}
