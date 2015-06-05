using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
	void Start ()
	{
		
	}
	
	void Update () 
	{
        if (!GameManager.gameStart)
            return;

        rigidbody2D.AddForce(new Vector2(Input.acceleration.x*1000, 0));
	} 
}
