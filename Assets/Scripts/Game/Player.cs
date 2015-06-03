using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
   // public Animator anim;
    public Text t;
	void Start ()
	{
		
	}
	
	void Update () 
	{
        if (!GameManager.gameStart)
            return;

        t.text = "Aelera: " + Input.acceleration.x;

        rigidbody2D.AddForce(new Vector2(Input.acceleration.x*1000, 0));
        //rigidbody2D.velocity = new Vector3(Input.acceleration.x * 1000, 0);
	}

    void OnCollisionEnter2D(Collision2D collision)
    {

    }

 
}
