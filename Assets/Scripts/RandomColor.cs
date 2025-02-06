using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; 
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
        spriteRenderer.color = Random.ColorHSV();
    }
}
