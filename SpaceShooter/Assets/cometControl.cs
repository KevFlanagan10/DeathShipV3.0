using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cometControl : MonoBehaviour
{
    public int cometEnemy;
    // Start is called before the first frame update
    void Start()
    {
        cometEnemy = Random.Range(1,3);

        if(cometEnemy == 1)
        {
             //Velocity & random
        GetComponent<Rigidbody2D> ().velocity = new Vector2(2,-2);
        }
        if(cometEnemy > 1)
        {
        GetComponent<Rigidbody2D> ().velocity = new Vector2(-2,-2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
