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
    public Image imagePause;
    public static GameManager gameManager;

    void Awake()
    {
        gameManager = gameObject.GetComponent<GameManager>();
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.fullScreen = true;
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

    public void Pause()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
            this.imagePause.sprite = Resources.Load<Sprite>("Menu/Botoes-02");
        }
        else
        {
            Time.timeScale = 1;
            this.imagePause.sprite = Resources.Load<Sprite>("Menu/Botoes-09");
        }
    }

    void SetScore(int _numberOfColors)
    {
        if (!gameStart)
            return;
        score +=(int)( 30 * Mathf.Pow(2f, (float)_numberOfColors));
        scoreText.text = "PONTOS: " + score ;
    }
}
