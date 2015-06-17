using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class CanvasManager : MonoBehaviour
{
    public Animator[] anims;
    public Image imageSound;
  
    public void PlayGame()
    {
        ChangeAnim("Game");
        GameManager.gameStart = true;
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
        if (GameManager.soundOn)
            imageSound.sprite = Resources.Load<Sprite>("Menu/Sound_Off");

        else
            imageSound.sprite = Resources.Load<Sprite>("Menu/Sound_On");
        GameManager.soundOn = !GameManager.soundOn;
    }

    public void Pause()
    {
        GameManager.isPaused = !GameManager.isPaused;
    }
}
