using UnityEngine;
using System.Collections;

public class CanvasManager : MonoBehaviour 
{
    public Canvas canvasMenu;
    public Canvas canvasGame;

    void Start()
    {
        canvasGame.enabled = false;
    }
    public void PlayGame()
    {
        canvasMenu.enabled = false;
        canvasGame.enabled = true;
    }
}
