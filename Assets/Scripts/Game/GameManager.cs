using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static bool gameStart;
    public static bool soundOn = true;
    public Animator[] anim;

	void Start () 
    {
	    
	}
	
	void Update () 
    {
        foreach (Animator a in anim)
        {
            a.SetBool("GameStart", gameStart);
        }

	}
}
