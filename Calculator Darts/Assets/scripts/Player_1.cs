using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class Player_1 : MonoBehaviour
{
    public int[] Score = new int[6] { 0, 0, 0, 0, 0, 0 };
    public GameObject[] round_1 = new GameObject[3];
    public GameObject[] round_2 = new GameObject[3];
    public GameObject[] round_3 = new GameObject[3];
    public GameObject[] round_4 = new GameObject[3];
    public GameObject[] round_5 = new GameObject[3];
    public ButtonCalc buttonCalc;
    public AddPlayer addPlayer;
    public int players;
    public bool Text;
    public bool g501, g301, g1001, UpdateStats;
    public bool p1, p2, p3, p4, p5, p6;
    public Text player_1, player_2, player_3, player_4, player_5;
    private void Start()
    {
        UpdateStats = true;
        p1 = true;
        Text = true;
        for (int i = 0; i < 5; i++)
        {
            Score[i] = 501;
        }
    }
    public void Update()

    {
        if (UpdateStats == true)
        {
            player_1.text = Score[0].ToString();
            player_2.text = Score[1].ToString();
            player_3.text = Score[2].ToString();
            player_4.text = Score[3].ToString();
            player_5.text = Score[4].ToString();
        }
      
       
        players = addPlayer.i + 1;
        if (players == 0)
        {
            player_1.text = Score[0].ToString();
            player_2.text = Score[1].ToString();
            player_3.text = Score[2].ToString();
            player_4.text = Score[3].ToString();
            player_5.text = Score[4].ToString();
        
        }

        if (players == 1)
        {
            if (buttonCalc.attempts == 1)
            {
                round_1[0].SetActive(true);

            }
            if (buttonCalc.attempts == 2)
            {
                round_1[1].SetActive(true);

            }
            if (buttonCalc.attempts == 3)
            {
                round_1[2].SetActive(true);

            }
            if (p1 == true && buttonCalc.attempts == 3)
            {
                Score[0] = (Score[0] - buttonCalc.Score);
                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                round_1[0].SetActive(false);
                round_1[1].SetActive(false);
                round_1[2].SetActive(false);
            }
        }
        if (players == 2)
        {
            if (p1 == true && buttonCalc.attempts == 1)
            {
                round_1[0].SetActive(true);

            }
            if (p1 == true && buttonCalc.attempts == 2)
            {
                round_1[1].SetActive(true);

            }
            if (p1 == true && buttonCalc.attempts == 3)
            {
                round_1[2].SetActive(true);

            }
            if (p2 == true && buttonCalc.attempts == 1)
            {
                round_2[0].SetActive(true);

            }
            if (p2 == true && buttonCalc.attempts == 2)
            {
                round_2[1].SetActive(true);

            }
            if (p2 == true && buttonCalc.attempts == 3)
            {
                round_2[2].SetActive(true);

            }

            if (p1 == true && buttonCalc.attempts == 3)
            {
                Score[0] = (Score[0] - buttonCalc.Score);

                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                p1 = false;
                p2 = true;
            }

            if (p2 == true && buttonCalc.attempts == 3)
            {
                Score[1] = (Score[1] - buttonCalc.Score);
                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                p1 = true;
                p2 = false;
                round_1[0].SetActive(false);
                round_1[1].SetActive(false);
                round_1[2].SetActive(false);
                round_2[0].SetActive(false);
                round_2[1].SetActive(false);
                round_2[2].SetActive(false);


            }
        }
        if (players == 3)
        {
            if (p1 == true && buttonCalc.attempts == 1)
            {
                round_1[0].SetActive(true);

            }
            if (p1 == true && buttonCalc.attempts == 2)
            {
                round_1[1].SetActive(true);

            }
            if (p1 == true && buttonCalc.attempts == 3)
            {
                round_1[2].SetActive(true);

            }
            if (p2 == true && buttonCalc.attempts == 1)
            {
                round_2[0].SetActive(true);

            }
            if (p2 == true && buttonCalc.attempts == 2)
            {
                round_2[1].SetActive(true);

            }
            if (p2 == true && buttonCalc.attempts == 3)
            {
                round_2[2].SetActive(true);

            }
            if (p3 == true && buttonCalc.attempts == 1)
            {
                round_3[0].SetActive(true);

            }
            if (p3 == true && buttonCalc.attempts == 2)
            {
                round_3[1].SetActive(true);

            }
            if (p3 == true && buttonCalc.attempts == 3)
            {
                round_3[2].SetActive(true);


            }

            if (p1 == true && buttonCalc.attempts == 3)
            {
                Score[0] = (Score[0] - buttonCalc.Score);
                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                p1 = false;
                p2 = true;
                p3 = false;
            }

            if (p2 == true && buttonCalc.attempts == 3)
            {
                Score[1] = (Score[1] - buttonCalc.Score);
                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                p1 = false;
                p2 = false;
                p3 = true;

            }

            if (p3 == true && buttonCalc.attempts == 3)
            {
                Score[2] = (Score[2] - buttonCalc.Score);
                round_1[0].SetActive(false);
                round_1[1].SetActive(false);
                round_1[2].SetActive(false);
                round_2[0].SetActive(false);
                round_2[1].SetActive(false);
                round_2[2].SetActive(false);
                round_3[0].SetActive(false);
                round_3[1].SetActive(false);
                round_3[2].SetActive(false);
                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                p1 = true;
                p2 = false;
                p3 = false;

            }
        }
        if (players == 4)
        {
            if (p1 == true && buttonCalc.attempts == 1)
            {
                round_1[0].SetActive(true);

            }
            if (p1 == true && buttonCalc.attempts == 2)
            {
                round_1[1].SetActive(true);

            }
            if (p1 == true && buttonCalc.attempts == 3)
            {
                round_1[2].SetActive(true);

            }
            if (p2 == true && buttonCalc.attempts == 1)
            {
                round_2[0].SetActive(true);

            }
            if (p2 == true && buttonCalc.attempts == 2)
            {
                round_2[1].SetActive(true);

            }
            if (p2 == true && buttonCalc.attempts == 3)
            {
                round_2[2].SetActive(true);

            }
            if (p3 == true && buttonCalc.attempts == 1)
            {
                round_3[0].SetActive(true);

            }
            if (p3 == true && buttonCalc.attempts == 2)
            {
                round_3[1].SetActive(true);

            }
            if (p3 == true && buttonCalc.attempts == 3)
            {
                round_3[2].SetActive(true);

            }
            if (p4 == true && buttonCalc.attempts == 1)
            {
                round_4[0].SetActive(true);

            }
            if (p4 == true && buttonCalc.attempts == 2)
            {
                round_4[1].SetActive(true);

            }
            if (p4 == true && buttonCalc.attempts == 3)
            {
                round_4[2].SetActive(true);

            }
            if (p1 == true && buttonCalc.attempts == 3)
            {
                Score[0] = (Score[0] - buttonCalc.Score);

                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                p1 = false;
                p2 = true;
                p3 = false;
                p4 = false;
            }


            if (p2 == true && buttonCalc.attempts == 3)
            {
                Score[1] = (Score[1] - buttonCalc.Score);

                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                p1 = false;
                p2 = false;
                p3 = true;
                p4 = false;

            }

            if (p3 == true && buttonCalc.attempts == 3)
            {
                Score[2] = (Score[2] - buttonCalc.Score);

                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                p1 = false;
                p2 = false;
                p3 = false;
                p4 = true;


            }

            if (p4 == true && buttonCalc.attempts == 3)
            {
                Score[3] = (Score[3 - buttonCalc.Score]);
                round_1[0].SetActive(false);
                round_1[1].SetActive(false);
                round_1[2].SetActive(false);
                round_2[0].SetActive(false);
                round_2[1].SetActive(false);
                round_2[2].SetActive(false);
                round_3[0].SetActive(false);
                round_3[1].SetActive(false);
                round_3[2].SetActive(false);
                round_4[0].SetActive(false);
                round_4[1].SetActive(false);
                round_4[2].SetActive(false);
                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                p1 = true;
                p2 = false;
                p3 = false;
                p4 = false;
            }
        }
        if (players == 5)
        {
            if (p1 == true && buttonCalc.attempts == 1)
            {
                round_1[0].SetActive(true);

            }
            if (p1 == true && buttonCalc.attempts == 2)
            {
                round_1[1].SetActive(true);

            }
            if (p1 == true && buttonCalc.attempts == 3)
            {
                round_1[2].SetActive(true);

            }
            if (p2 == true && buttonCalc.attempts == 1)
            {
                round_2[0].SetActive(true);

            }
            if (p2 == true && buttonCalc.attempts == 2)
            {
                round_2[1].SetActive(true);

            }
            if (p2 == true && buttonCalc.attempts == 3)
            {
                round_2[2].SetActive(true);

            }
            if (p3 == true && buttonCalc.attempts == 1)
            {
                round_3[0].SetActive(true);

            }
            if (p3 == true && buttonCalc.attempts == 2)
            {
                round_3[1].SetActive(true);

            }
            if (p3 == true && buttonCalc.attempts == 3)
            {
                round_3[2].SetActive(true);

            }
            if (p4 == true && buttonCalc.attempts == 1)
            {
                round_4[0].SetActive(true);

            }
            if (p4 == true && buttonCalc.attempts == 2)
            {
                round_4[1].SetActive(true);

            }
            if (p4 == true && buttonCalc.attempts == 3)
            {
                round_4[2].SetActive(true);

            }
            if (p5 == true && buttonCalc.attempts == 1)
            {
                round_5[0].SetActive(true);

            }
            if (p5 == true && buttonCalc.attempts == 2)
            {
                round_5[1].SetActive(true);

            }
            if (p5 == true && buttonCalc.attempts == 3)
            {
                round_5[2].SetActive(true);

            }
            if (p1 == true && buttonCalc.attempts == 3)
            {
                Score[0] = (Score[0] - buttonCalc.Score);

                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                p1 = false;
                p2 = true;
                p3 = false;
                p4 = false;
                p5 = false;
            }
            if (p2 == true && buttonCalc.attempts == 3)
            {
                Score[1] = (Score[1] - buttonCalc.Score);

                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                p1 = false;
                p2 = false;
                p3 = true;
                p4 = false;
                p5 = false;

            }
            if (p3 == true && buttonCalc.attempts == 3)
            {
                Score[2] = (Score[2] - buttonCalc.Score);

                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                p1 = false;
                p2 = false;
                p3 = false;
                p4 = true;
                p5 = false;


            }
            if (p4 == true && buttonCalc.attempts == 3)
            {
                Score[3] = (Score[3] - buttonCalc.Score);

                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                p1 = false;
                p2 = false;
                p3 = false;
                p4 = false;
                p5 = true;
            }
            if (p5 == true && buttonCalc.attempts == 3)
            {
                Score[4] = (Score[4] - buttonCalc.Score);
                round_1[0].SetActive(false);
                round_1[1].SetActive(false);
                round_1[2].SetActive(false);
                round_2[0].SetActive(false);
                round_2[1].SetActive(false);
                round_2[2].SetActive(false);
                round_3[0].SetActive(false);
                round_3[1].SetActive(false);
                round_3[2].SetActive(false);
                round_4[0].SetActive(false);
                round_4[1].SetActive(false);
                round_4[2].SetActive(false);
                round_5[0].SetActive(false);
                round_5[1].SetActive(false);
                round_5[2].SetActive(false);
                buttonCalc.attempts = 0;
                buttonCalc.Score = 0;
                p1 = true;
                p2 = false;
                p3 = false;
                p4 = false;
                p5 = false;

            }
          
        }

      
   
    }
    public void btngame_301()
    {
        for (int i = 0; i < 5; i++)
        {
            Score[i] = 301;
        }
        p1 = true;
        p2 = false;
        p3 = false;
        p4 = false;
        p5 = false;
        p6 = false;
        buttonCalc.attempts = 0;
        buttonCalc.Score = 0;
        round_1[0].SetActive(false);
        round_1[1].SetActive(false);
        round_1[2].SetActive(false);
        round_2[0].SetActive(false);
        round_2[1].SetActive(false);
        round_2[2].SetActive(false);
        round_3[0].SetActive(false);
        round_3[1].SetActive(false);
        round_3[2].SetActive(false);
        round_4[0].SetActive(false);
        round_4[1].SetActive(false);
        round_4[2].SetActive(false);
        round_5[0].SetActive(false);
        round_5[1].SetActive(false);
        round_5[2].SetActive(false);

    }
    public void btngame_501()
    {
        for (int i = 0; i < 5; i++)
        {
            Score[i] = 501;
        }
        p1 = true;
        p2 = false;
        p3 = false;
        p4 = false;
        p5 = false;
        p6 = false;
        buttonCalc.attempts = 0;
        buttonCalc.Score = 0;
        round_1[0].SetActive(false);
        round_1[1].SetActive(false);
        round_1[2].SetActive(false);
        round_2[0].SetActive(false);
        round_2[1].SetActive(false);
        round_2[2].SetActive(false);
        round_3[0].SetActive(false);
        round_3[1].SetActive(false);
        round_3[2].SetActive(false);
        round_4[0].SetActive(false);
        round_4[1].SetActive(false);
        round_4[2].SetActive(false);
        round_5[0].SetActive(false);
        round_5[1].SetActive(false);
        round_5[2].SetActive(false);
    }
    public void btngame_1001()
    {
        for (int i = 0; i < 5; i++)
        {
            Score[i] = 1001;
        }
        p1 = true;
        p2 = false;
        p3 = false;
        p4 = false;
        p5 = false;
        p6 = false;
        buttonCalc.attempts = 0;
        buttonCalc.Score = 0;
        round_1[0].SetActive(false);
        round_1[1].SetActive(false);
        round_1[2].SetActive(false);
        round_2[0].SetActive(false);
        round_2[1].SetActive(false);
        round_2[2].SetActive(false);
        round_3[0].SetActive(false);
        round_3[1].SetActive(false);
        round_3[2].SetActive(false);
        round_4[0].SetActive(false);
        round_4[1].SetActive(false);
        round_4[2].SetActive(false);
        round_5[0].SetActive(false);
        round_5[1].SetActive(false);
        round_5[2].SetActive(false);
    }
}



        
    
 
