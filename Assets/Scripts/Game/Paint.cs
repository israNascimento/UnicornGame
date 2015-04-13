using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Paint : MonoBehaviour {

    public Dictionary<string, GameObject> paints = new Dictionary<string, GameObject>();
	void Start ()
    {
        paints.Add("Yellow", GameObject.Find("Yellow_PB"));
        paints.Add("Green",  GameObject.Find("Green_PB"));
        paints.Add("Blue",   GameObject.Find("Blue_PB"));
        paints.Add("Gray",   GameObject.Find("Gray_PB"));
	}

    public void PaintObject(string color)
    {
        SpriteRenderer sprite = paints[color].GetComponent<SpriteRenderer>();
        sprite.sprite = Resources.Load<Sprite>("Game/Textures/Back/" + color + "/" + color + "_Painted");
    }
}
