using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class CanvasManager : MonoBehaviour
{
    public Animator[] anims;
    public Image imageSound;
    GameManager gameManager;

    void Start()
    {
        gameManager = GameManager.gameManager;
    }
  
    public void PlayGame()
    {
        ChangeAnim("Game");
        gameManager.gameStart = true;
    }

    public void ButtonClick(string s)
    {
        ChangeAnim(s);
    }

    private void ChangeAnim(string s)
    {
        foreach (Animator a in anims)
        {
            if (a.GetBool(s) != null)
            {
                a.SetBool(s, !a.GetBool(s));
            }
        }
    }

    public void SoundClick()
    {
        if (gameManager.soundOn)
            imageSound.sprite = Resources.Load<Sprite>("Menu/Buttons/RED BUTTONS/Botoes-15");

        else
            imageSound.sprite = Resources.Load<Sprite>("Menu/Buttons/RED BUTTONS/Botoes-16");
        gameManager.soundOn = !gameManager.soundOn;
    }

    public void Pause()
    {
        gameManager.Pause();
    }

    public void Reload()
    {
        Application.LoadLevel(0);
    }
}
