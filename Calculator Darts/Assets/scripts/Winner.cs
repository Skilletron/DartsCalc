using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    public Player_1 player;
    public TMP_Text text;
    public AddPlayer addPlayer;
    public GameObject win;
    public void Update()
    {

        for(int i = 0; i<=4 ; i++)
        {
            if (player.Score[i] <= 0)
            {
                text.text = addPlayer.name[i].text;
                player.Score[i] = 0;
                win.SetActive(true);

            }
       
        }
   }
    public void Button_Restart()
    {
        win.SetActive(false);
        
    }
    public void Button_Exit()
    {
        Application.Quit();
    }
}
