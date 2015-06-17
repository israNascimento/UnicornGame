using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    GameManager gameManager;
	void Start ()
	{
        gameManager = GameManager.gameManager;
        print(gameManager);
	}
	
	void Update () 
	{
        if (!gameManager.gameStart)
            return;

        rigidbody2D.AddForce(new Vector2(Input.acceleration.x*1000, 0));
	}
}
