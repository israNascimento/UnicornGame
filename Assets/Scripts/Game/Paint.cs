using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Paint : MonoBehaviour 
{
    [System.Serializable]
    public class ScrollBarController
    {
        public string key;
        public bool isPainted;
        public float currentTime;
        public Scrollbar scroll; 
    }
    
    public GameObject[] mapPB;
    public ScrollBarController[] scrollController;
    private Dictionary<string, bool> isPainted = new Dictionary<string, bool>();
    private const int TIME = 10;
    GameManager gameManager;

    void Start()
    {
        isPainted.Add("Vermelho", false);
        gameManager = GameManager.gameManager;
    }

    void Update()
    {
        foreach (ScrollBarController sbc in scrollController)
        {
            if (sbc.isPainted)
            {
                sbc.scroll.enabled = true;
                sbc.currentTime -= Time.deltaTime;
                sbc.scroll.size = sbc.currentTime/TIME;
	        }

            if (sbc.currentTime < 0f)
            {
                sbc.isPainted = false;
                sbc.scroll.enabled = false;
                Decolorize(sbc.key);
            }
        }
    }
    
    
    public void PaintObject(string color)
    {
        foreach (GameObject g in mapPB)
            g.transform.FindChild(color).gameObject.SetActive(true);


        foreach (ScrollBarController sbc in scrollController)
        {
            if (sbc.key.Equals(color))
            {
                sbc.isPainted = true;
                sbc.currentTime = 10;
            }
        }
    }

    private void Decolorize(string color)
    {
        foreach (GameObject g in mapPB)
        {
            g.transform.FindChild(color).gameObject.SetActive(false);
        }        
    }
}
