using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class backcredit : MonoBehaviour {
	public Canvas credits;
	public Canvas info;
	public Canvas tap;
	public Canvas main;
	public GameObject a;

	// Use this for initialization
	public void Start () {

	}

	// Update is called once per frame
	public void backcr () {
		main.enabled = true;
		info.enabled = false;
		tap.enabled = false;
		credits.enabled = false;
		a.SetActive(false);
	}
}
