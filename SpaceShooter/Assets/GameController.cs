using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
public Texture2D defaultTexture;
public CursorMode curMode = CursorMode.Auto;
public Vector2 hotSpot = Vector2.zero;

public Vector2 mousePosition;
public static Vector2 objPosition;
public static Vector2 targetPosition;

public KeyCode fireMissile;

public Transform MissileObj;

public Transform lockOnTarget;

public Transform enemyObj;

public static int remainingMissiles = 10;
//Can use this as a difficult setting with less missiles

public Transform countObj; 

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor (defaultTexture, hotSpot, curMode); 
    }

    // Update is called once per frame
    void Update()
    {
        countObj.GetComponent<TextMesh>().text = remainingMissiles.ToString();
        //must use to string because its a number to text
        mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
        objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
        
        if(Input.GetKeyDown (fireMissile))
        {
            Instantiate(MissileObj, new Vector2(0,-4),MissileObj.rotation);
            Instantiate(lockOnTarget, objPosition, lockOnTarget.rotation);
            remainingMissiles -= 1;
        }
    }
}
