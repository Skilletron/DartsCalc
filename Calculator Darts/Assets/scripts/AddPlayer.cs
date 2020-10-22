using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddPlayer : MonoBehaviour
{
    public GameObject NeedName;
    public GameObject[] playeradd = new GameObject[6];
    public GameObject[] buttonplus = new GameObject[6];
    public Text[] score = new Text[6];
    public Text[] name = new Text[6] ;
    public InputField field;
    public Player_1 player;
    public ButtonCalc btn;
    public int i;
    private void Awake()
    {
        i = -1;
    }
    public void Update()
    {
        if (i < 0)
        {
            btn.attempts = 0;
            btn.Score = 0;
            player.round_1[0].SetActive(false);
            player.round_1[1].SetActive(false);
            player.round_1[2].SetActive(false);
            player.round_2[0].SetActive(false);
            player.round_2[1].SetActive(false);
            player.round_2[2].SetActive(false);
            player.round_3[0].SetActive(false);
            player.round_3[1].SetActive(false);
            player.round_3[2].SetActive(false);
            player.round_4[0].SetActive(false);
            player.round_4[1].SetActive(false);
            player.round_4[2].SetActive(false);
            player.round_5[0].SetActive(false);
            player.round_5[1].SetActive(false);
            player.round_5[2].SetActive(false);
        }
       
    }
    public void PlayerClickAdd()
    {
        TouchScreenKeyboard.Open(name[i].ToString(""));
        NeedName.SetActive(true);
        i++;
        playeradd[i].SetActive(true);
        buttonplus[i].SetActive(false);

    }
    public void Next()
    {
        NeedName.SetActive(false);
        name[i].text = field.text;
        if (name[i].text == "")
        {
            name[i].text = "PLAYER" + (i+1).ToString("");
        }
        
        score[i].text = "0";
    }

}
