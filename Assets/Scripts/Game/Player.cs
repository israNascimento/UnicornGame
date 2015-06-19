using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;


    GameManager gameManager;
    public Text x;
	void Start ()
	{
        gameManager = GameManager.gameManager;
	}
	
	void Update () 
	{
        if (!gameManager.gameStart)
            return;

          this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Input.acceleration.x * 5, 0));
    } 
}
