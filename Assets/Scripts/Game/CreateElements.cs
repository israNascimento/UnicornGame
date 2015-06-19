using UnityEngine;
using System.Collections;

public class CreateElements : MonoBehaviour {

    [Header("Enemys")]
    [Space(10)]
    public GameObject[] obstacles;
    private float currentTimeEnemys;
    private Vector3 position;

    [Header("Paints")]
    [Space(10)]
    public GameObject[] paints;
    public int limitNumber;
    public int random;
    private const int numberToInstantiate = 10;

    [Header("Clouds")]
    [Space(10)]
    public GameObject[] clouds;
    public float currentTimeClouds;

    GameManager gameManager;

    void Start()
    {
        gameManager = GameManager.gameManager;
    }

    void Update () 
    {
        if (!gameManager.gameStart)
            return;


        if (GetTime(3, ref currentTimeEnemys))
        {
            position = new Vector3(Random.Range(-6.32f, 6.75f), 12, -1);
           // Instantiate(obstacles[Random.Range(0, obstacles.Length)], position, Quaternion.identity);
        }

        if (GetTime(3, ref currentTimeClouds))
        {

        }

        random = Random.Range(0, limitNumber);
        if (random == numberToInstantiate)
        {
            position = new Vector3(Random.Range(-6.32f, 6.75f), 25, -1);
            Instantiate(paints[Random.Range(0, paints.Length)], position, Quaternion.identity);
        }
	}

    private bool GetTime(float limitTime, ref float currentTime)
    {
        currentTime += Time.deltaTime;
        if (currentTime > limitTime)
        {
            currentTime = 0;
            return true;
        }

        return false;
    }
}
