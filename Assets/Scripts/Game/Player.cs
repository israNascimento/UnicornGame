using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
<<<<<<< HEAD
    GameManager gameManager;
=======
<<<<<<< HEAD
    GameManager gameManager;
=======
    public Text x;
>>>>>>> origin/master
>>>>>>> origin/master
	void Start ()
	{
        gameManager = GameManager.gameManager;
	}
	
	void Update () 
	{
        if (!gameManager.gameStart)
            return;

<<<<<<< HEAD
          this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Input.acceleration.x * 5, 0));
=======
<<<<<<< HEAD
          this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Input.acceleration.x * 5, 0));
=======
       //   x.text = "Acelerometro X: " + Time.deltaTime + "Vel: "+gameObject.rigidbody2D.velocity;
          this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Input.acceleration.x * 10, 0));
      //  transform.position += new Vector3(Input.acceleration.x / 2, 0);
>>>>>>> origin/master
>>>>>>> origin/master
    } 
}
