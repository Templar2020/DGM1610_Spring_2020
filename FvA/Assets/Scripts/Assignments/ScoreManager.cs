using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// In order to use UI functions you must access the UI library.
using UnityEngine.UI;
// This library is used to manage scenes, including loading scenes.
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public int winScore;

    public Text winText;

	private Text scoreText;  

    // On Awake run this block of code
	void Awake(){
		Time.timeScale = 1;
	}

	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text>();

		score = 0;

		winText.GetComponent<Text>().enabled = false;
 	}

    // Update is called once per frame
    void Update()
    {
       if (score < 0)
			score = 0; 
                       
		scoreText.text = " " + score;

		// If the player wins the game, display win text!
		if(score >= winScore ){
			print("Win Score Reached = " + score);
			winText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}
        // If player hits the Escape key return to start menu
		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
		}
    }

    public static void AddPoints(int pointsToAdd){
        
        score += pointsToAdd;         
    }

	public static void SubPoint(int pointsToSub){
		score -= pointsToSub;
	}
   
}
