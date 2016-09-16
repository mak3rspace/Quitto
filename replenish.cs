using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class replenish : MonoBehaviour {
	public Text rep;

	void Start () {
	
	}
	

	void Update (){}

	public void Rep(){
		
			StarLauncher gameController = FindObjectOfType<StarLauncher> ();

		if (gameController.stars <= 0) {
			StarLauncher ameController = FindObjectOfType<StarLauncher> ();

			GameController.stars = 5;
			rep.text=""+gameController.stars;
				Debug.Log ("hesdxazsds");
			}	
		}

}

