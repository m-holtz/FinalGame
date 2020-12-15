using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public AudioSource theMusic;

    public bool startPlaying; //the music

    public BeatScroller theBeat; //the beat scroller

    public static GameManager instance; //note hit or miss all around

    public int currentScore; //Current score

    public int scorePerNote = 1; //Value of score per note

    public Text scoreText;


   
    private void Awake()
    {
        instance = this;

      
    }


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: 0 ";

    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theBeat.hasStarted = true;
                theMusic.Play();
            }
        }

       
    }

    public void NoteHit()
    {
        //Debug.Log("Hit Note");

            currentScore += scorePerNote; //adds score
            scoreText.text = "Score: " + currentScore;
        
     }

    public void NoteMissed()
    {
       // Debug.Log("Missed Note");
    }
}
