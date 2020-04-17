using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-2,0);// going from right to left
        Destroy(gameObject, 12);//time of boss
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "BOOM(Clone)")
        {
            GameController.currentScore += 500;
            Destroy(gameObject);
        }
    }
}
