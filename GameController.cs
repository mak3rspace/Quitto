using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public bool isGameOver;
	public Text scoreTxt;
	public Text gameOverTxt;
	public Canvas gameOverCanvas;
	public Text highscore;
	public Text starno;public int _scoreToWin = 10000;


	private int _currScore;
	private bool _didIWin;


	void start(){
		
		ResetGame ();

	}
	void NewGame() {
		
		StarLauncher gameController = FindObjectOfType<StarLauncher> ();
		gameController.stars = 5;
		ResetGame();



	}
	

	
	public void GotOne() {
		_currScore+=1;
		scoreTxt.text =  "" + _currScore;
		highscore.text = "Highscore: " + _currScore;


		if (_currScore >= _scoreToWin) {
			GameOver(true);
		
		}
	}
	
	
	public void GameOver(bool didIWin) {
		isGameOver = true;

		_didIWin = didIWin;
		gameOverTxt.text = (_didIWin) ? "Congrats :)" : "Try Again :(";

		gameOverCanvas.enabled = true;
		StarLauncher gameController = FindObjectOfType<StarLauncher> ();
		gameController.stars = 5;
 	}
	

	public void ResetGame() {
	
		gameOverCanvas.enabled = false;
		isGameOver = false;
		_currScore = 0;
		scoreTxt.text = "--";
	
		starno.text =  "--";
		StarLauncher gameController = FindObjectOfType<StarLauncher> ();
		gameController.stars = 5;


        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies) {
        	Destroy(enemy);
        }
        
        GameObject[] Stars = GameObject.FindGameObjectsWithTag("Star");
        foreach (GameObject ninjaStar in Stars) {
        	Destroy (Star);
        }
	}
	

	
}
