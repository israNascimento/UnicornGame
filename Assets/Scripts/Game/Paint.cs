using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Paint : MonoBehaviour {

   // public Dictionary<string, GameObject> paints = new Dictionary<string, GameObject>();

    public GameObject[] mapPB;
	void Start ()
    {
       /* paints.Add("Vermelho", GameObject.Find("Yellow_PB"));
        paints.Add("Green",  GameObject.Find("Green_PB"));
        paints.Add("Blue",   GameObject.Find("Blue_PB"));
        paints.Add("Gray",   GameObject.Find("Gray_PB"));*/
	}

    public void PaintObject(string color)
    {
        foreach (GameObject g in mapPB)
            g.transform.FindChild(color).gameObject.SetActive(true);
    }
}
