using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class home : MonoBehaviour {
	public Canvas credits;
	public Canvas info;
	public Canvas tap;
	public Canvas main;
	public GameObject a;
	public GameObject b;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	public void hom () {
		GameController b = FindObjectOfType<GameController> ();
		b.ResetGame();
		main.enabled = true;
		info.enabled = false;
		tap.enabled = false;
		credits.enabled = false;
		a.SetActive(false);
	}
}
