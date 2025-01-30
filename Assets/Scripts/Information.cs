using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class Information : MonoBehaviour
{
    public TextMeshProUGUI change;
    public GameObject shape; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (mouse.y > 0.5 && mouse.y < 1 && mouse.x > 0.5 && mouse.x < 1)
        {
            change.text = shape.ToString();      
        }
    }
}
