using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MissileControl : MonoBehaviour
{
    public float timeKeeper = 0;
    public float fracDist =.01f;

    public Transform boomObj;
    // Start is called before the first frame update
    void Start()
    {
        GameController.targetPosition = GameController.objPosition;
        GetComponent<Transform> ().eulerAngles = new Vector3 (0,0,0);
    }//set the missile to shoot at an angle

    // Update is called once per frame
    void Update()
    {
        timeKeeper += Time.deltaTime;

        if(timeKeeper > .03)
        {
            fracDist += .01f;
            timeKeeper = 0;
        }

        //changes position 
        //Lerp sets up two points
        transform.position = Vector2.Lerp(transform.position, GameController.targetPosition, fracDist);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "CH2(Clone)")
        {
            Destroy(gameObject);
            Instantiate(boomObj, transform.position, boomObj.rotation);
        }
    }
}
