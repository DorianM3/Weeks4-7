using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteOnOff : MonoBehaviour
{

    public Canvas canv;
    public Transform cake;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cakepos = cake.position;
        Vector2 pos = transform.position; 

        if(cakepos.x + 2 > pos.x && cakepos.x - 2 < pos.x && cakepos.y + 2 > pos.y && cakepos.y - 2 < pos.y)
        {
          canv.enabled = true; 
        }

        else
        {
            canv.enabled = false; 
        }

    }
}
