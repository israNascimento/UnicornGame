using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameStart;

    public bool soundOn = true;
    public Animator[] anim;
    public int currentColors, score;
    public Text scoreText;

    public static GameManager gameManager;

    void Awake()
    {
        gameManager = gameObject.GetComponent<GameManager>();
    }

    void Start () 
    {
        score = 0;
	}
	
	void FixedUpdate () 
    {
        foreach (Animator a in anim)
        {
            a.SetBool("GameStart", gameStart);
        }
        SetScore(currentColors);
	}

    void SetScore(int numberOfColors)
    {
        score += 1+numberOfColors;
        scoreText.text = "PONTOS: " + score;
        print(numberOfColors);
    }
}
