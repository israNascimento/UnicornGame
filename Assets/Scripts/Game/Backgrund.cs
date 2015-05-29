using UnityEngine;
using System.Collections;

public class Backgrund : MonoBehaviour
{
    const float SPEED = -0.008f;

	void Start () 
    {
	
	}
	
	void Update () 
    {
        transform.position += new Vector3(0, SPEED);
	}
}
