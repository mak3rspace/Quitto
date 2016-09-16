using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class i : MonoBehaviour {
	public Canvas credits;
	public Canvas info;
	public Canvas tap;
	public Canvas main;
	public GameObject a;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	public void inform () {
		main.enabled = false;
		info.enabled = true;
		tap.enabled = false;
		credits.enabled = false;
		a.SetActive(false);
	}
}
