using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour 
{
    public GameObject[] buttons;
    Animator anim;
	
    public void ChangeScene(string scene)
    {
		foreach (GameObject g in buttons)
		{
			g.GetComponent<Animator>().SetBool("GoConfig", true);
		}
    }
}
