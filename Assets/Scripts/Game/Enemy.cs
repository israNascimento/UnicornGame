using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public float speed;
	void Start ()
    {

	}
	
	void Update ()
    {
        transform.position -= new Vector3(0, (speed )*Time.deltaTime);
	}
}
