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
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newsmoke = Instantiate(smokeup, train.position, train.rotation);
            Destroy(newsmoke, 2); 
        }
    }
}
