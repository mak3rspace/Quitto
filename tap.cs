using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tap : MonoBehaviour {
	public Canvas credits;
	public Canvas info;
	public Canvas taps;
	public Canvas main;
	public GameObject a;
	public Canvas gameOverCanvas;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	public void tapp () {
		
		main.enabled = false;
		info.enabled = false;
		taps.enabled = true;
		credits.enabled = false;
		a.SetActive(true);
		gameOverCanvas.enabled = false;
	}
}
