using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Move : MonoBehaviour
{
    public float speed;
    public GameObject newaxe;
    bool triggered;
    

    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        Axe myAxe = newaxe.GetComponent<Axe>();
        Vector2 playerpos;
        playerpos = transform.position; 

        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0); 

        if(playerpos.x >= -7.5 && playerpos.x <= -6.5 && playerpos.y >= -4.5 && playerpos.y <= -3.5)
        {
            triggered = true; 
            
           
        }

        if (triggered)
        {
            myAxe.Activated();
        }



    }
}
