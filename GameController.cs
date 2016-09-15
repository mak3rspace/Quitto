using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public bool isGameOver;
	public Text scoreTxt;
	public Text gameOverTxt;
	public Canvas gameOverCanvas;

	private int _currScore;
	private int _scoreToWin = 20;
	private bool _didIWin;

	
	void NewGame() {
		ResetGame();
	}
	

	
	public void GotOne() {
		_currScore+=5;
		scoreTxt.text =  "" + _currScore;
		if (_currScore >= _scoreToWin) {
			GameOver(true);
		}
	}

	public void GameOver(bool didIWin) {
		isGameOver = true;
			_didIWin = didIWin;
		gameOverTxt.text = (_didIWin) ? "Congrats :)" : "Try Again :(";
		gameOverCanvas.enabled = true;
 	}
	

	
	public void ResetGame() {
		// Reset the interface
		gameOverCanvas.enabled = false;
		isGameOver = false;
		_currScore = 0;
		scoreTxt.text = "--";
        
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies) {
        	Destroy(enemy);
        }
        
        GameObject[] ninjaStars = GameObject.FindGameObjectsWithTag("Star");
        foreach (GameObject nStar in Stars) {
        	Destroy (Star);
        }
	}
	
	void Start () {
		NewGame();
	}
	
}
