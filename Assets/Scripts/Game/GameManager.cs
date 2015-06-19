using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameStart;

    public bool soundOn = true;
    public Animator[] anim;
<<<<<<< HEAD
    public int numberOfColors, score;
    public Text scoreText;

    public static GameManager gameManager;

    void Awake()
    {
        gameManager = gameObject.GetComponent<GameManager>();
    }
=======
    public static bool isPaused = false;
>>>>>>> origin/master

    void Start()
    {
        score = 0;
    }

    void FixedUpdate()
    {
        /*foreach (Animator a in anim)
        {
            a.SetBool("GameStart", gameStart);
<<<<<<< HEAD
        }
        SetScore(numberOfColors);
    }

    void SetScore(int _numberOfColors)
    {
        score += 1 + _numberOfColors;
        scoreText.text = "PONTOS: " + score;
    }
=======
        }*/

      
	}
>>>>>>> origin/master
}
