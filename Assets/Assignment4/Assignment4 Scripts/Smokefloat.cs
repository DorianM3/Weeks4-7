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
        Vector2 smokepos;
        smokepos = transform.position;
        smokepos.y += up * Time.deltaTime;
        transform.position = smokepos; 
    }
}
