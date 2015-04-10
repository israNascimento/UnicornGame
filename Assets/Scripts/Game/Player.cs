using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed;


	void Start ()
	{
		
	}
	
	void Update () 
	{
		if (Input.acceleration.x != 0) 
		{
            rigidbody2D.AddForce(new Vector2(Input.acceleration.x*50, 0));
		}
	}

    void OnCollisionEnter2D(Collision2D collision)
    {

    }

 
}
