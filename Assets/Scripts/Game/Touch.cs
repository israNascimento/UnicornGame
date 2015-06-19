using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour 
{

    private float speed = 40;
    Player player;
    GameManager gameManager;

	void Start ()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        gameManager = GameManager.gameManager;
    }
	
	
	void Update () 
    {
	
	}

    void OnMouseDown()
    {
        print(gameObject.tag);

        if (!gameManager.gameStart)
            return;

        if (gameObject.tag.Equals("touchL"))
        {
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
            print(gameObject.tag);
        }


        if (gameObject.tag.Equals("touchR"))
        {
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
        }
    }
}
