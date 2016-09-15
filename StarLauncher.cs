using UnityEngine;
using System.Collections;

public class StarLauncher : MonoBehaviour {

	public GameObject user;
	public StarController ninjaStar;
	public AudioSource whooshSound;
	public int stars;
	private GameController _gameController;
	private Vector3 _shooterOffset;
	private float _nextLaunchTime;
	void Start () {
		_gameController = this.GetComponent<GameController>();
		_shooterOffset = new Vector3(0.0f, 0.8f, 1.0f);


		
	}
	
	void Update () {

	

		if (Input.GetButtonDown ("Fire1") && !_gameController.isGameOver) {
						Vector3 mouseLoc = Input.mousePosition;
			Vector3 worldMouseLoc = Camera.main.ScreenToWorldPoint (mouseLoc);
			worldMouseLoc.y = ninja.transform.position.y;
			user.transform.LookAt (worldMouseLoc);


			if (stars > 0) 
			{
				LaunchStarFrom (user, _shooterOffset);
				stars -= 1;
					}	

		}
	}



	void LaunchNinjaStarFrom(GameObject origin, Vector3 shooterOffset) {
		
		
		Vector3 nStarRotation = origin.transform.rotation.eulerAngles;
		StarRotation.x = 90.0f;
		Vector3 transformedOffset = origin.transform.rotation * shooterOffset;
		Instantiate(Star, origin.transform.position + transformedOffset, Quaternion.Euler(ninjaStarRotation));
		
	
		whooshSound.Play();
		
	}
	
}
