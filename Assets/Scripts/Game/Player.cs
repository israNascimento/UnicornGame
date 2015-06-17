using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public Text x;
	void Start ()
	{
		
	}
	
	void Update () 
	{
        if (!GameManager.gameStart)
            return;

       //   x.text = "Acelerometro X: " + Time.deltaTime + "Vel: "+gameObject.rigidbody2D.velocity;
          this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Input.acceleration.x * 10, 0));
      //  transform.position += new Vector3(Input.acceleration.x / 2, 0);
    } 
}
