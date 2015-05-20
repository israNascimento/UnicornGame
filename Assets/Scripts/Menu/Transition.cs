using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour 
{
    public GameObject[] buttons;
    Animator anim;
	
    public void ChangeScene(string scene)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            print("JJ");
            buttons[i].GetComponent<Animator>().SetBool("GoConfig", true);
        }
    }
}
