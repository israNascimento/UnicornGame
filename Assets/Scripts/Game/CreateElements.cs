using UnityEngine;
using System.Collections;

public class CreateElements : MonoBehaviour {

    [Header("Enemys")]
    [Space(10)]
    public GameObject[] obstacles;
    public float timeToInstanceEnemys;
    public float currentTime;
    private Vector3 position;

    [Header("Paints")]
    [Space(10)]
    public GameObject[] paints;
    public int limitNumber;
    public int random;
    private const int numberToInstantiate = 10;

	void Start ()
    {
	    
	}
	
	void Update () 
    {
        currentTime += Time.deltaTime;

        if (currentTime > timeToInstanceEnemys)
        {
            position = new Vector3(Random.Range(-6.32f, 6.75f), 12, -1);
            Instantiate(obstacles[Random.Range(0, obstacles.Length)], position, Quaternion.identity);
            currentTime = 0;
        }

        random = Random.Range(0, limitNumber);

        if (random == numberToInstantiate)
        {
            position = new Vector3(Random.Range(-6.32f, 6.75f), 12, -1);
            Instantiate(paints[Random.Range(0, paints.Length)], position, Quaternion.identity);
        }
	}
}
