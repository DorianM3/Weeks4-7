using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0, 1)]
    public float t;
    public float flip; 
    public AnimationCurve curve; 

    void Start()
    {
        t = 0.1f;
        flip = 0.1f; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);  

        if(mouse.y > 1 && mouse.y < 2)
        {
            t += flip * Time.deltaTime;
            transform.localScale = Vector2.one * curve.Evaluate(t); 
        }

        if(t >= 0.99 || t <= 0.01)
        {
            flip *= -1; 
        }


    }
}
