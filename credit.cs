using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class credit : MonoBehaviour {
	public Canvas credits;
	public Canvas info;
	public Canvas tap;
	public Canvas main;
	public GameObject a;

	// Use this for initialization
	public void Start () {
	
	}
	
	// Update is called once per frame
	public void credi () {
		main.enabled = false;
		info.enabled = false;
		tap.enabled = false;
		credits.enabled = true;
		a.SetActive(false);
	}
}
