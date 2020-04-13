using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
public Texture2D defaultTexture;
public CursorMode curMode = CursorMode.Auto;
public Vector2 hotSpot = Vector2.zero;

public Vector2 mousePosition;
public Vector2 objPosition;

public KeyCode fireMissile;

public Transform MissileObj;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor (defaultTexture, hotSpot, curMode); 
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
        objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
        
        if(Input.GetKeyDown (fireMissile))
        {
            Instantiate(MissileObj, new Vector2(0,-4.26),MissileObj.rotation);
        }
    }
}
