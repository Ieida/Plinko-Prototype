using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score_Script : MonoBehaviour
{

    public float ScorePoints;
    public static float Highscore;

    
    private GameObject Player;
    public GameObject Position_Ancor_01;
    

    

    public TextMeshProUGUI Score_text;
    public TextMeshProUGUI PopUp_Score;
    public TextMeshProUGUI Money_Text;
    public TextMeshProUGUI ScoreAtEnd_Text;

    public TextMeshProUGUI HighScore_Text;

    public GameObject HighscoreText_Text;

    public Animator PopUp_Text;

    public static float Money;
    public float PointsThisRound;
    

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {



        Score_text.SetText("" + ScorePoints);
        Money_Text.SetText("" + Money);
        HighScore_Text.SetText("" + Highscore);
        ScoreAtEnd_Text.SetText("" + ScorePoints);

        if (ScorePoints >= Highscore)
        {
            Highscore = ScorePoints;
            HighscoreText_Text.SetActive(true);
        }
        else
        {
            HighscoreText_Text.SetActive(false);
        }


        /* 
        ScorePoints += 1;
            PointsThisRound += 1;
            PopUp_Score.SetText("1");
            PopUp_Text.Play("PopUp_Text");

       

       
       */

        //Distance_01 = Vector3.Distance(Position_Ancor_01.transform.position, Player.transform.position);
        


    }

    public void PointsThisRoundNull()
    {
        Money += PointsThisRound;
        PointsThisRound = 0;
        
        Debug.Log("Foxtrot_Works");
    }

    public void Add(int points)
    {
        
        Debug.Log("Alpha_Works");
        ScorePoints += points;
        PointsThisRound += points;
        // Multiplikators also Collectabls
        Money += PointsThisRound;
        Debug.Log(Money);
    }

}
