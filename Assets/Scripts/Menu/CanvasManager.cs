using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour 
{
    public Canvas canvasMenu;
    public Canvas canvasGame;
    public Animator Animators;
    public Image imageSound;

    void Start()
    {
        canvasGame.enabled = false;
    }

    public void PlayGame()
    {
        canvasMenu.enabled = false;
        canvasGame.enabled = true;
        GameManager.gameStart = true;
    }

    public void Config()
    {
        Animators.SetBool("Config", !Animators.GetBool("Config"));
    }

    public void SoundClick()
    {
        if (GameManager.soundOn)
            imageSound.sprite = Resources.Load<Sprite>("Menu/Sound_Off");

        else
            imageSound.sprite = Resources.Load<Sprite>("Menu/Sound_On");
        GameManager.soundOn = !GameManager.soundOn;
    }
}
