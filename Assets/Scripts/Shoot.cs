using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform tank; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 tankpos = tank.position; 
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newthing = Instantiate(bullet, tankpos, transform.rotation);
            Destroy(newthing, 5); 
        }
        
    }
}
