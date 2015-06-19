using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameStart;

    public bool soundOn = true;
    public Animator[] anim;
    public int numberOfColors, score;
    public Text scoreText;

    public static GameManager gameManager;

    void Awake()
    {
        gameManager = gameObject.GetComponent<GameManager>();
    }
    public static bool isPaused = false;

    void Start()
    {
        score = 0;
    }

    void FixedUpdate()
    {
        foreach (Animator a in anim)
        {
            a.SetBool("GameStart", gameStart);
        }
        SetScore(numberOfColors);
    }

    void SetScore(int _numberOfColors)
    {
        if (!gameStart)
            return;
        score += 30 * _numberOfColors+1;
        scoreText.text = "PONTOS: " + score;
    }
}
