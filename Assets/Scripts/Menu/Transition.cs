using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour 
{
    public GameObject[] buttons;
    Animator anim;

    private string[] currentScene = {"Menu", "Config"};
    public void ChangeScene(string scene)
    {

        foreach (GameObject g in buttons)
        {
            foreach (string s in currentScene)
            {
                g.GetComponent<Animator>().SetBool("Go" + s, !g.GetComponent<Animator>().GetBool("Go" + s));
            }
        }
    }
}
