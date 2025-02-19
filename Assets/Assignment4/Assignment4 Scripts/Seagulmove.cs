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
        Vector2 seagulpos;
        seagulpos = transform.position;
        seagulpos.x += speed * Time.deltaTime; 

        if(seagulpos.x > 15)
        {
            seagulpos.x = -20; 
        }

        transform.position = seagulpos;
    }
}
