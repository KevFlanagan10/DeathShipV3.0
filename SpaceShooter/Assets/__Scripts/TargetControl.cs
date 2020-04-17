using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetControl : MonoBehaviour
{
public AudioSource playerShot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "missile(Clone)")
        {
            Destroy(gameObject);
        }
        
        playerShot.Play(); 
        
    }//this will destroy the crosshairs
}
