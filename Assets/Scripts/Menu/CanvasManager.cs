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
            imageSound.sprite = Resources.Load<Sprite>("Menu/Sound_Off");

        else
            imageSound.sprite = Resources.Load<Sprite>("Menu/Sound_On");
        gameManager.soundOn = !gameManager.soundOn;
    }

<<<<<<< HEAD
   /* public void Pause()
    {
        gameManager.isPaused = !gameManager.isPaused;
    }*/
=======
<<<<<<< HEAD
   /* public void Pause()
    {
        gameManager.isPaused = !gameManager.isPaused;
    }*/
=======
    public void Pause()
    {
        GameManager.isPaused = !GameManager.isPaused;
    }
>>>>>>> origin/master
>>>>>>> origin/master
}
