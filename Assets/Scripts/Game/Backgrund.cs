using UnityEngine;
using System.Collections;

public class Backgrund : MonoBehaviour
{
    const float SPEED = -1f;

	void Start () 
    {
	
	}
	
	void Update () 
    {
        transform.position += new Vector3(0, SPEED*Time.deltaTime);
	}
}
