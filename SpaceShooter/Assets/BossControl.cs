using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-4,0);
        Destroy(gameObject, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
