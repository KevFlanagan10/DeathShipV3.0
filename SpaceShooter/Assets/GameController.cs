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

public Transform enemyObj;//comet!

public static int remainingMissiles = 100;
//Can use this as a difficult setting with less missiles

public float spawnTimer;

public int spawnPosition;

public static int currentScore = 0;
public Transform scoreObj;

public Transform bossObj;

public Transform countObj; 

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor (defaultTexture, hotSpot, curMode); 

        Instantiate(bossObj, bossObj.position, bossObj.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        enemySpawn();

        countObj.GetComponent<TextMesh>().text = remainingMissiles.ToString();
        //must use to string because its a number to text
        mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
        objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
        scoreObj.GetComponent<TextMesh>().text = "Score: " + currentScore;

        if((Input.GetKeyDown (fireMissile)) && (remainingMissiles > 0))
        {
            Instantiate(MissileObj, new Vector2(0,-4),MissileObj.rotation);
            Instantiate(lockOnTarget, objPosition, lockOnTarget.rotation);
            remainingMissiles -= 1;
        }
    }

    void enemySpawn()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer > 2)
        {
            spawnPosition = Random.Range (-7, 7);
            spawnTimer = 0;
            Instantiate(enemyObj, new Vector2 (spawnPosition, 6), enemyObj.rotation);
        }
    }
}
